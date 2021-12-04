using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace Aplicacion.Examenes
{
    public class ExamenConsulta
    {
        public class Ejecuta : IRequest<List<PerfilDto>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<PerfilDto>>
        {
            private readonly netLISContext _context;
            private readonly IMapper _mapper;
            
            public Manejador(netLISContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<PerfilDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var perfil = await _context.TblCatPerfiles
                    .Include(x => x.TblCatPerfilesExamenes)
                    .ThenInclude(x => x.IdExamenNavigation).ToListAsync();

                var perfilDto = _mapper.Map<List<TblCatPerfile>, List<PerfilDto>>(perfil);
                return perfilDto;
            }
        }
    }
}

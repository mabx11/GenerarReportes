using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.TipoServicio
{
    public class ListTipoServicio
    {
        public class Ejecuta : IRequest<List<TblCatTipoServicio>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblCatTipoServicio>>
        {
            private readonly netLISContext _context;
            public Manejador(netLISContext context)
            {
                _context = context;
            }
            public async Task<List<TblCatTipoServicio>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tiposervicio = await _context.TblCatTipoServicios.ToListAsync();
                return tiposervicio;
            }
        }
    }
}

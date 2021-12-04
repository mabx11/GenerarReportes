using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Model;
using Aplicacion.Examenes;

namespace Aplicacion
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<TblExamene, ExamenDto>();
            CreateMap<TblCatPerfilesExamene, PerfilExamenDto>();
            CreateMap<TblCatPerfile, PerfilDto>().ForMember(x => x.Examenes, y => y.MapFrom(z => z.TblCatPerfilesExamenes.Select(a => a.IdExamenNavigation).ToList())); ;
        }
    }
}

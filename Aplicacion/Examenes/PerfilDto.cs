using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Examenes
{
    public class PerfilDto
    {
        public int IdPerfiles { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public ICollection<ExamenDto> Examenes { get; set; }

    }
}

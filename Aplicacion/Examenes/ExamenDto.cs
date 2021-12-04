using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Examenes
{
    public class ExamenDto
    {
        public int IdExamen { get; set; }
        public int IdAreaLabServicio { get; set; }
        public int IdCategoriaExamenes { get; set; }
        public int IdTipoMuestra { get; set; }
        public int IdUnidadMedidas { get; set; }
        public int IdTipoResultado { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Confidencial { get; set; }
        public int Estado { get; set; }
    }
}

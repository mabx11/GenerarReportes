using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblResultado
    {
        public int IdResultados { get; set; }
        public int? IdExamen { get; set; }
        public int IdOrden { get; set; }
        public string Resultado { get; set; }
        public string Observaciones { get; set; }
        public string Procesado { get; set; }
        public DateTime? FechaProcesa { get; set; }
        public string UsuarioProcesa { get; set; }
        public string Validado { get; set; }
        public DateTime? FechaValida { get; set; }
        public string UsuarioValida { get; set; }
        public int? Impreso { get; set; }
        public DateTime? FechaImprime { get; set; }
        public string UsuarioImprime { get; set; }
        public int Estado { get; set; }

        public virtual TblExamene IdExamenNavigation { get; set; }
        public virtual TblOrdene IdOrdenNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblOrdenesDetalle
    {
        public int IdOrdenDetalle { get; set; }
        public int IdOrden { get; set; }
        public string NOrden { get; set; }
        public int IdExamen { get; set; }
        public string Activo { get; set; }

        public virtual TblExamene IdExamenNavigation { get; set; }
        public virtual TblOrdene IdOrdenNavigation { get; set; }
    }
}

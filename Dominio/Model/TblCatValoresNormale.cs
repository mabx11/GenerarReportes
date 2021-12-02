using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatValoresNormale
    {
        public int IdValoresNormales { get; set; }
        public int IdExamen { get; set; }
        public int IdSexo { get; set; }
        public double RangoAlto { get; set; }
        public double RangoBajo { get; set; }
        public int Estado { get; set; }

        public virtual TblExamene IdExamenNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
    }
}

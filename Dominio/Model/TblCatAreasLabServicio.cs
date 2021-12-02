using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatAreasLabServicio
    {
        public TblCatAreasLabServicio()
        {
            TblAreaServLabEmpleados = new HashSet<TblAreaServLabEmpleado>();
            TblExamenes = new HashSet<TblExamene>();
        }

        public int IdAreaLabServicio { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public virtual ICollection<TblExamene> TblExamenes { get; set; }
    }
}

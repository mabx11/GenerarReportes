using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblAreaServLabEmpleado
    {
        public int IdAreaServLabEmpleados { get; set; }
        public int? IdAreaLabServicio { get; set; }
        public int IdEmpleado { get; set; }
        public int IdSucursal { get; set; }

        public virtual TblCatAreasLabServicio IdAreaLabServicioNavigation { get; set; }
        public virtual TblEmpleado IdEmpleadoNavigation { get; set; }
        public virtual TblCatSucursale IdSucursalNavigation { get; set; }
    }
}

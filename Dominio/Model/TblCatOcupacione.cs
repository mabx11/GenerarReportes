using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatOcupacione
    {
        public int IdOcupaciones { get; set; }
        public int IdEmpleado { get; set; }
        public int IdProfesiones { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEmpleado IdEmpleadoNavigation { get; set; }
        public virtual TblCatProfesione IdProfesionesNavigation { get; set; }
    }
}

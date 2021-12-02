using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatProfesione
    {
        public TblCatProfesione()
        {
            TblCatOcupaciones = new HashSet<TblCatOcupacione>();
            TblEmpleados = new HashSet<TblEmpleado>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public int IdProfesiones { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatOcupacione> TblCatOcupaciones { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}

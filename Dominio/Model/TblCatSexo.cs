using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatSexo
    {
        public TblCatSexo()
        {
            TblCatValoresNormales = new HashSet<TblCatValoresNormale>();
            TblEmpleados = new HashSet<TblEmpleado>();
            TblMedicos = new HashSet<TblMedico>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public int IdSexo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblCatValoresNormale> TblCatValoresNormales { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblMedico> TblMedicos { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}

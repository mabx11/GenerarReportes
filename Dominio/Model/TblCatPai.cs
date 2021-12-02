using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPai
    {
        public TblCatPai()
        {
            TblCatSucursales = new HashSet<TblCatSucursale>();
            TblEmpleadoIdPaisNacNavigations = new HashSet<TblEmpleado>();
            TblEmpleadoIdPaisResNavigations = new HashSet<TblEmpleado>();
            TblMedicoIdPaisNacNavigations = new HashSet<TblMedico>();
            TblMedicoIdPaisResNavigations = new HashSet<TblMedico>();
            TblPacienteIdPaisNacNavigations = new HashSet<TblPaciente>();
            TblPacienteIdPaisResNavigations = new HashSet<TblPaciente>();
        }

        public int IdPais { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatSucursale> TblCatSucursales { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleadoIdPaisNacNavigations { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleadoIdPaisResNavigations { get; set; }
        public virtual ICollection<TblMedico> TblMedicoIdPaisNacNavigations { get; set; }
        public virtual ICollection<TblMedico> TblMedicoIdPaisResNavigations { get; set; }
        public virtual ICollection<TblPaciente> TblPacienteIdPaisNacNavigations { get; set; }
        public virtual ICollection<TblPaciente> TblPacienteIdPaisResNavigations { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatDepartamento
    {
        public TblCatDepartamento()
        {
            TblCatSucursales = new HashSet<TblCatSucursale>();
            TblEmpleadoIdDepartamentoNacNavigations = new HashSet<TblEmpleado>();
            TblEmpleadoIdDepartamentoResNavigations = new HashSet<TblEmpleado>();
            TblMedicoIdDepartamentoNacNavigations = new HashSet<TblMedico>();
            TblMedicoIdDepartamentoResNavigations = new HashSet<TblMedico>();
            TblPacienteIdDepartamentoNacNavigations = new HashSet<TblPaciente>();
            TblPacienteIdDepartamentoResNavigations = new HashSet<TblPaciente>();
        }

        public int IdDepartamento { get; set; }
        public int IdPais { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatSucursale> TblCatSucursales { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleadoIdDepartamentoNacNavigations { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleadoIdDepartamentoResNavigations { get; set; }
        public virtual ICollection<TblMedico> TblMedicoIdDepartamentoNacNavigations { get; set; }
        public virtual ICollection<TblMedico> TblMedicoIdDepartamentoResNavigations { get; set; }
        public virtual ICollection<TblPaciente> TblPacienteIdDepartamentoNacNavigations { get; set; }
        public virtual ICollection<TblPaciente> TblPacienteIdDepartamentoResNavigations { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblEmpleado
    {
        public TblEmpleado()
        {
            TblAreaServLabEmpleados = new HashSet<TblAreaServLabEmpleado>();
            TblCatOcupaciones = new HashSet<TblCatOcupacione>();
        }

        public int IdEmpleado { get; set; }
        public int IdProfesiones { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdDepartamentoNac { get; set; }
        public int IdDepartamentoRes { get; set; }
        public int IdPaisNac { get; set; }
        public int IdPaisRes { get; set; }
        public int IdIdentificacion { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdSexo { get; set; }
        public int IdNacionalidad { get; set; }
        public string NumIdentificacion { get; set; }
        public string NumInss { get; set; }
        public string CodMinsa { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string EdadIngreso { get; set; }
        public string Email { get; set; }
        public string DireccionDomiciliar { get; set; }
        public string TelefonoDomiciliar { get; set; }
        public string TelefonoMovil { get; set; }
        public DateTime FechaContrato { get; set; }
        public string UrlFoto { get; set; }
        public string Activo { get; set; }
        public int Estado { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public string UsuarioElimina { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNacNavigation { get; set; }
        public virtual TblCatDepartamento IdDepartamentoResNavigation { get; set; }
        public virtual TblCatEstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual TblCatIdentificacion IdIdentificacionNavigation { get; set; }
        public virtual TblCatNacionalidad IdNacionalidadNavigation { get; set; }
        public virtual TblCatPai IdPaisNacNavigation { get; set; }
        public virtual TblCatPai IdPaisResNavigation { get; set; }
        public virtual TblCatProfesione IdProfesionesNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
        public virtual ICollection<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public virtual ICollection<TblCatOcupacione> TblCatOcupaciones { get; set; }
    }
}

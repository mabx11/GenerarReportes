using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblPaciente
    {
        public TblPaciente()
        {
            TblOrdenes = new HashSet<TblOrdene>();
        }

        public int IdPaciente { get; set; }
        public int IdIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string NumInss { get; set; }
        public int IdEstadoCivil { get; set; }
        public string Email { get; set; }
        public int IdSexo { get; set; }
        public int IdPaisNac { get; set; }
        public int IdDepartamentoNac { get; set; }
        public int IdPaisRes { get; set; }
        public int IdDepartamentoRes { get; set; }
        public int IdTipoSangre { get; set; }
        public int IdProfesiones { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string DireccionDomiciliar { get; set; }
        public string TelefonoDomiciliar { get; set; }
        public string TelefonoMovil { get; set; }
        public string Activo { get; set; }
        public string Emabrazada { get; set; }
        public string Fallecido { get; set; }
        public int Estado { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNacNavigation { get; set; }
        public virtual TblCatDepartamento IdDepartamentoResNavigation { get; set; }
        public virtual TblCatEstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual TblCatIdentificacion IdIdentificacionNavigation { get; set; }
        public virtual TblCatPai IdPaisNacNavigation { get; set; }
        public virtual TblCatPai IdPaisResNavigation { get; set; }
        public virtual TblCatProfesione IdProfesionesNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
        public virtual TblCatTipoSangre IdTipoSangreNavigation { get; set; }
        public virtual ICollection<TblOrdene> TblOrdenes { get; set; }
    }
}

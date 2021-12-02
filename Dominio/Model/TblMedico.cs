using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblMedico
    {
        public TblMedico()
        {
            TblOrdenes = new HashSet<TblOrdene>();
        }

        public int IdTblMedico { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdtblCatSucursales { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public int IdDepartamentoNac { get; set; }
        public int IdDepartamentoRes { get; set; }
        public int IdPaisNac { get; set; }
        public int IdPaisRes { get; set; }
        public int IdIdentificacion { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdSexo { get; set; }
        public string NumIdentificacion { get; set; }
        public string CodMinsa { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string UrlFoto { get; set; }
        public int Estado { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNacNavigation { get; set; }
        public virtual TblCatDepartamento IdDepartamentoResNavigation { get; set; }
        public virtual TblCatEstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual TblCatIdentificacion IdIdentificacionNavigation { get; set; }
        public virtual TblCatPai IdPaisNacNavigation { get; set; }
        public virtual TblCatPai IdPaisResNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
        public virtual TblCatSucursale IdtblCatSucursalesNavigation { get; set; }
        public virtual ICollection<TblOrdene> TblOrdenes { get; set; }
    }
}

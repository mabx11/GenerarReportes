using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblExamene
    {
        public TblExamene()
        {
            TblCatIndicacionExaPacientes = new HashSet<TblCatIndicacionExaPaciente>();
            TblCatPerfilesExamenes = new HashSet<TblCatPerfilesExamene>();
            TblCatValoresNormales = new HashSet<TblCatValoresNormale>();
            TblOrdenesDetalles = new HashSet<TblOrdenesDetalle>();
            TblResultados = new HashSet<TblResultado>();
        }

        public int IdExamen { get; set; }
        public int IdAreaLabServicio { get; set; }
        public int IdCategoriaExamenes { get; set; }
        public int IdTipoMuestra { get; set; }
        public int IdUnidadMedidas { get; set; }
        public int IdTipoResultado { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Confidencial { get; set; }
        public int Estado { get; set; }

        public virtual TblCatAreasLabServicio IdAreaLabServicioNavigation { get; set; }
        public virtual TblCatCategoriaExamene IdCategoriaExamenesNavigation { get; set; }
        public virtual TblCatTipoMuestra IdTipoMuestraNavigation { get; set; }
        public virtual TblCatTipoResultado IdTipoResultadoNavigation { get; set; }
        public virtual TblCatUnidadMedida IdUnidadMedidasNavigation { get; set; }
        public virtual ICollection<TblCatIndicacionExaPaciente> TblCatIndicacionExaPacientes { get; set; }
        public virtual ICollection<TblCatPerfilesExamene> TblCatPerfilesExamenes { get; set; }
        public virtual ICollection<TblCatValoresNormale> TblCatValoresNormales { get; set; }
        public virtual ICollection<TblOrdenesDetalle> TblOrdenesDetalles { get; set; }
        public virtual ICollection<TblResultado> TblResultados { get; set; }

        public ICollection<TblCatPerfilesExamene> PerfilExamenLink { get; set;}
    }
}

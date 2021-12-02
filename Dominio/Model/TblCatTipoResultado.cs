using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoResultado
    {
        public TblCatTipoResultado()
        {
            TblExamenes = new HashSet<TblExamene>();
        }

        public int IdTipoResultado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblExamene> TblExamenes { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoServicio
    {
        public TblCatTipoServicio()
        {
            TblOrdenes = new HashSet<TblOrdene>();
        }

        public int IdTipoServicio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblOrdene> TblOrdenes { get; set; }
    }
}

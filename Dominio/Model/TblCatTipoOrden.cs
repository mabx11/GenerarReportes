using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoOrden
    {
        public TblCatTipoOrden()
        {
            TblOrdenes = new HashSet<TblOrdene>();
        }

        public int IdTipoOrden { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblOrdene> TblOrdenes { get; set; }
    }
}

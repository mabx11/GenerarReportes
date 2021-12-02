using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatHospital
    {
        public TblCatHospital()
        {
            TblCatSucursales = new HashSet<TblCatSucursale>();
        }

        public int IdHospital { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatSucursale> TblCatSucursales { get; set; }
    }
}

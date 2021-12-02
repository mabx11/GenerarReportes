using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPerfile
    {
        public TblCatPerfile()
        {
            TblCatPerfilesExamenes = new HashSet<TblCatPerfilesExamene>();
        }

        public int IdPerfiles { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatPerfilesExamene> TblCatPerfilesExamenes { get; set; }
    }
}

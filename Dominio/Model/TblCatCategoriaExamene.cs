using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatCategoriaExamene
    {
        public TblCatCategoriaExamene()
        {
            TblExamenes = new HashSet<TblExamene>();
        }

        public int IdCategoriaExamenes { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblExamene> TblExamenes { get; set; }
    }
}

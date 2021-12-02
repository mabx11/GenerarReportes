using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPerfilesExamene
    {
        public int IdPerfilesExamenes { get; set; }
        public int IdExamen { get; set; }
        public int IdPerfiles { get; set; }

        public virtual TblExamene IdExamenNavigation { get; set; }
        public virtual TblCatPerfile IdPerfilesNavigation { get; set; }
    }
}

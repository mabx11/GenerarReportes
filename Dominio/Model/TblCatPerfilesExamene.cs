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

        public TblExamene IdExamenNavigation { get; set; }
        public TblCatPerfile IdPerfilesNavigation { get; set; }
    }
}

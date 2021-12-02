using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatIndicacionExaPaciente
    {
        public int IdIndicacionExaPaciente { get; set; }
        public int IdExamen { get; set; }
        public string Indicacion { get; set; }

        public virtual TblExamene IdExamenNavigation { get; set; }
    }
}

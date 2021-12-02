using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoSangre
    {
        public TblCatTipoSangre()
        {
            TblPacientes = new HashSet<TblPaciente>();
        }

        public int IdTipoSangre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}

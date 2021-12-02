﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblOrdene
    {
        public TblOrdene()
        {
            TblOrdenesDetalles = new HashSet<TblOrdenesDetalle>();
            TblResultados = new HashSet<TblResultado>();
        }

        public int IdOrden { get; set; }
        public string NOrden { get; set; }
        public int IdtblMedico { get; set; }
        public int IdPaciente { get; set; }
        public int IdTipoServicio { get; set; }
        public int IdTipoOrden { get; set; }
        public string Asistencia { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaOrden { get; set; }
        public string Activo { get; set; }
        public DateTime? FechaImprime { get; set; }
        public string UsuarioImprime { get; set; }
        public int Estado { get; set; }
        public string Finalizado { get; set; }
        public DateTime? FechaCita { get; set; }
        public DateTime FechaPreporte { get; set; }

        public virtual TblPaciente IdPacienteNavigation { get; set; }
        public virtual TblCatTipoOrden IdTipoOrdenNavigation { get; set; }
        public virtual TblCatTipoServicio IdTipoServicioNavigation { get; set; }
        public virtual TblMedico IdtblMedicoNavigation { get; set; }
        public virtual ICollection<TblOrdenesDetalle> TblOrdenesDetalles { get; set; }
        public virtual ICollection<TblResultado> TblResultados { get; set; }
    }
}

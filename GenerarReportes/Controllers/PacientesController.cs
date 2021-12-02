using Aplicacion.Paciente;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerarReportes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblPaciente>>> Get()
        {
            return await Mediator.Send(new ListPaciente.Ejecuta());
        }
    }
}

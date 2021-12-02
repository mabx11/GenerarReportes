using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Examenes;
using Dominio.Model;

namespace GenerarReportes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PerfilDto>>> Get()
        {
            return await Mediator.Send(new ExamenConsulta.Ejecuta());
        }
    }
}

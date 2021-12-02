using Aplicacion.Ordenes;
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
    public class OrdenesController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblOrdene>>> Get()
        {
            return await Mediator.Send(new ListOrdenes.Ejecuta());
        }
    }
}

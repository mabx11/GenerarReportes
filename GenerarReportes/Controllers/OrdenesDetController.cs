using Aplicacion.OrdenDet;
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
    public class OrdenesDetController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblOrdenesDetalle>>> Get()
        {
            return await Mediator.Send(new ListOrdenDet.Ejecuta());
        }
    }
}

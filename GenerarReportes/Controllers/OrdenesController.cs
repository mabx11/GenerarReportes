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

        //[HttpGet("{id}")]
        //public async Task<ActionResult<TblOrdene>> Detalle(int id)
        //{
        //    return await Mediator.Send(new ConsultaId.CursoUnico { Id = id });
        //}

        //[HttpPost]
        //public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        //{
        //    return await Mediator.Send(data);
        //}
    }
}

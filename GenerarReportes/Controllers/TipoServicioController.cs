﻿using Aplicacion.TipoServicio;
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
    public class TipoServicioController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblCatTipoServicio>>> Get()
        {
            return await Mediator.Send(new ListTipoServicio.Ejecuta());
        }
    }
}

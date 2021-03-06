﻿using Aplicacion.EstadosCiviles;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosCivilesController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<EstadosCiviles>>> Get()
        {
            return await Mediator.Send(new Consulta.Listado());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EstadosCiviles>> Detalle(string id)
        {
            return await Mediator.Send(new ConsultaId.Unico{Id = id});
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Post(Nuevo.Ejecuta data)
        {
            return await Mediator.Send(data);            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Put(string id,Editar.Ejecuta data)
        {
            data.Id = id;
            return await Mediator.Send(data);
        }
    }
}
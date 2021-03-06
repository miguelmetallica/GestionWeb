﻿using Aplicacion.TiposDocumentos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposDocumentosController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TiposDocumentos>>> Get()
        {
            return await Mediator.Send(new Consulta.Listado());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TiposDocumentos>> Detalle(string id)
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
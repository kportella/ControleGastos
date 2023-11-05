﻿using Microsoft.AspNetCore.Mvc;
using Servicos.Dtos;
using Servicos.Implementacoes;
using Servicos.Interfaces;

namespace ControleGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaServico categoriaServico;

        public CategoriaController(ICategoriaServico categoriaServico)
        {
            this.categoriaServico = categoriaServico;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos() 
        {
            var categorias = await categoriaServico.BuscarTodos();

            return Ok(categorias);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> BuscarPorId([FromRoute] Guid id)
        {
            var categoria = await categoriaServico.BuscarPorId(id);

            if (categoria == null) { return NotFound(); }

            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] CategoriaDto categoria)
        {
            var categoriaRetorno = await categoriaServico.Criar(categoria);
            return CreatedAtAction(nameof(BuscarPorId), new { id = categoriaRetorno.Id }, categoriaRetorno);

        }

    }
}

using Microsoft.AspNetCore.Mvc;
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
    }
}

using Microsoft.AspNetCore.Mvc;
using Servicos.Dtos;
using Servicos.Interfaces;

namespace ControleGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {

        private readonly ITransacaoServico transacaoServico;


        public TransacaoController(ITransacaoServico transacaoServico)
        {
            this.transacaoServico = transacaoServico;
        }

        [HttpGet]
        public IActionResult BuscarTodos() { return NotFound(); }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult BuscarPorId([FromRoute] Guid id) { return NotFound(); }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] TransacaoDto transacao) 
        {
            var transacaoRetorno = await transacaoServico.Criar(transacao);
            return CreatedAtAction(nameof(Adicionar), new {id = transacaoRetorno.Id}, transacaoRetorno);
        }

        [HttpPut]
        public IActionResult Atualizar() { return NotFound(); }

        [HttpDelete]
        public IActionResult Deletar() { return NotFound(); }
        
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ControleGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : Controller
    {
        [HttpGet]
        public IActionResult BuscarTodos() { return View(); }

        [HttpGet]
        public IActionResult BuscarPorId() { return View(); }

        [HttpPost]
        public IActionResult Adicionar() { return View(); }

        [HttpPut]
        public IActionResult Atualizar() { return View(); }

        [HttpDelete]
        public IActionResult Deletar() { return View(); }
        
    }
}

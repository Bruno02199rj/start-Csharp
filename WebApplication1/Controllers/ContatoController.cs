using ControllerContato.Repositorio;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace ControllerContato.Controllers

{

public class ContatoController : Controller

{
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
    {
        return View();
    }

     public IActionResult Criar()
    {
        return View();
    }
     public IActionResult Editar()
    {
        return View();
    }
     public IActionResult ApagarConfirmacao()
    {
        return View();
    }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");

        }
}

}

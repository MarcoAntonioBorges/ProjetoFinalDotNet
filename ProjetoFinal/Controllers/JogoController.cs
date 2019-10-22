using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;
using ProjetoFinal.repository;

namespace ProjetoFinal.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _repository;

        public JogoController(IJogoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _repository.Cadastrar(jogo);
            _repository.Salvar();
            ViewData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Cadastrar");
        }
    }
}
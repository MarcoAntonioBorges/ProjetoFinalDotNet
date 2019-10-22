using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoFinal.Models;
using ProjetoFinal.repository;

namespace ProjetoFinal.Controllers
{
    public class JogoController : Controller
    {
        private IJogoRepository _repository;
        private IGeneroRepository _repositoryGenero;

        public JogoController(IJogoRepository repository, IGeneroRepository generoRepository)
        {
            _repository = repository;
            _repositoryGenero = generoRepository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.generos = new SelectList(_repositoryGenero.Listar(), "GeneroId", "Nome");
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogo jogo)
        {
            _repository.Cadastrar(jogo);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View("Listar", _repository.ListarJuntoGenero());
        }
    }
}
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
    public class GeneroController : Controller
    {
        private IGeneroRepository _repository;

        public GeneroController(IGeneroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Genero genero)
        {
            _repository.Cadastrar(genero);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso!!";
            return RedirectToAction("Cadastrar");
        }


    }
}
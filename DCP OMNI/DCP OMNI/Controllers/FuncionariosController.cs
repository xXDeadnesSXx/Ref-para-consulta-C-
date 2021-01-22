using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCP_OMNI.Services;
using DCP_OMNI.Models;

namespace DCP_OMNI.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        private readonly CargoService _cargoService;
        public FuncionariosController(FuncionarioService funcionarioService, CargoService cargoService)
        {
            _funcionarioService = funcionarioService;
            _cargoService = cargoService;
        }
        public IActionResult Index()
        {
            var list = _funcionarioService.FindAll();
            return View(list);
        }
        //GET
        public IActionResult Create()
        {
            var cargos = _cargoService.FindAll();
            var viewModel = new FuncionarioFormViewModel { Cargos = cargos};
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario)
        {
            _funcionarioService.Insert(funcionario);
            return RedirectToAction(nameof(Index));
        }
        //GET
        public IActionResult Delete(int? id)//Recebe um id opcional
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _funcionarioService.FindById(id.Value);//id.Value pq id é opcional
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);//caso exista ele chama a view passando o obj
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _funcionarioService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        //GET
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _funcionarioService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}

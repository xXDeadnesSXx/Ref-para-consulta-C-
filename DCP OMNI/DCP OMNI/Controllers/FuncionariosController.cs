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
    }
}

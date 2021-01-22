using DCP_OMNI.Models;
using DCP_OMNI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Controllers
{
    public class CargosController : Controller
    {
        private readonly CargoService _cargoService;
        public CargosController(CargoService cargoService)
        {
            _cargoService = cargoService;
        }
        public IActionResult Index()
        {
            var list = _cargoService.FindAll();
            return View(list);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cargo cargo)
        {
            _cargoService.Insert(cargo);
            return RedirectToAction(nameof(Index));
        }
    }
}

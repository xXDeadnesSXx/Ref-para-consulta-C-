using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DCP_OMNI.Data;
using DCP_OMNI.Models;
using DCP_OMNI.Services;

namespace DCP_OMNI.Controllers
{
    public class MateriaisController : Controller
    {
        private readonly MaterialService _materialService;
        public MateriaisController(MaterialService materialService)
        {
            _materialService = materialService;
        }
        public IActionResult Index()
        {
            var list = _materialService.FindAll();
            return View(list);
        }
    }
}

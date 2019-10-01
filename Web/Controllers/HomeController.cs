using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly GranadoFluxoContext _dbContext;
        private readonly Services.Categoria _serviceCategoria;
        public HomeController(GranadoFluxoContext dbContext, Services.Categoria serviceCategoria)
        {
            _dbContext = dbContext;
            _serviceCategoria = serviceCategoria;
        }
        public IActionResult Index()
        {
            var categoria = _serviceCategoria.GetAll();

            return View(categoria);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var categoria = _serviceCategoria.GetById(id);

            return View(categoria);
        }
        [HttpPost]
        public IActionResult Editar(DataAccess.Model.Categoria model)
        {
            if (ModelState.IsValid)
            {
                _serviceCategoria.Update(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

          
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

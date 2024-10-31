using GeradorDeNarrativas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeradorDeNarrativas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult _Configuracoes()
        {
            return View("Modal/_Configuracoes");
        }
    }
}

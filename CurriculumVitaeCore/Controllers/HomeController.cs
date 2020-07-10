using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CurriculumVitaeCore.Models;

namespace CurriculumVitaeCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            _logger.LogInformation("Appel de la page Index");
            return View();
        }

        public IActionResult About()
        {
            _logger.LogWarning("Appel de la page About");
            return View();
        }

        public IActionResult Contact()
        {
            _logger.LogError("Appel de la page Contact");
            return View();
        }
    }
}

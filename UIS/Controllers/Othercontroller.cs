using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class Othercontroller : Controller
    {
        private readonly ILogger<Othercontroller> _logger;

        public Othercontroller(ILogger<Othercontroller> logger)
        {
            _logger = logger;
        }

        public IActionResult DevicesandPorts()
        {
            return View();
        }
        public IActionResult UnitShutDown()
        {
            return View();
        }
        public IActionResult NewUnitOpenings()
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

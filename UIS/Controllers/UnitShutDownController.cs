using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class UnitShutDownController : Controller
    {
        private readonly ILogger<UnitShutDownController> _logger;

        public UnitShutDownController(ILogger<UnitShutDownController> logger)
        {
            _logger = logger;
        }

        public IActionResult UnitShutDown()
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

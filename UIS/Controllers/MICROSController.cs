using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class MICROSController : Controller
    {
        private readonly ILogger<MICROSController> _logger;

        public MICROSController(ILogger<MICROSController> logger)
        {
            _logger = logger;
        }

        public IActionResult MICROS()
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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class NewUnitOpeningController : Controller
    {
        private readonly ILogger<NewUnitOpeningController> _logger;

        public NewUnitOpeningController(ILogger<NewUnitOpeningController> logger)
        {
            _logger = logger;
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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class UISController : Controller
    {
        private readonly ILogger<UISController> _logger;

        public UISController(ILogger<UISController> logger)
        {
            _logger = logger;
        }

        public IActionResult UIS()
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

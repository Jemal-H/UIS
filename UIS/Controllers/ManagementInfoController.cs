using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class ManagementInfoController : Controller
    {
        private readonly ILogger<ManagementInfoController> _logger;

        public ManagementInfoController(ILogger<ManagementInfoController> logger)
        {
            _logger = logger;
        }

        public IActionResult ManagementInfo()
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

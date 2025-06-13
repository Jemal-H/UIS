using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class DevicesandPortsController : Controller
    {
        private readonly ILogger<DevicesandPortsController> _logger;

        public DevicesandPortsController(ILogger<DevicesandPortsController> logger)
        {
            _logger = logger;
        }

        public IActionResult DevicesandPorts()
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

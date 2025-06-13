using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class UISHelpTabsController : Controller
    {
        private readonly ILogger<UISHelpTabsController> _logger;

        public UISHelpTabsController(ILogger<UISHelpTabsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UIS()
        {
            return View();
        }

        public IActionResult MICROS()
        {
            return View();
        }

        public IActionResult AssociateInfo()
        {
            return View();
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

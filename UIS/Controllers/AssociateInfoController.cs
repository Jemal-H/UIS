using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UIS.Models;

namespace UIS.Controllers
{
    public class AssociateInfoController : Controller
    {
        private readonly ILogger<AssociateInfoController> _logger;

        public AssociateInfoController(ILogger<AssociateInfoController> logger)
        {
            _logger = logger;
        }

        public IActionResult AssociateInfo()
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

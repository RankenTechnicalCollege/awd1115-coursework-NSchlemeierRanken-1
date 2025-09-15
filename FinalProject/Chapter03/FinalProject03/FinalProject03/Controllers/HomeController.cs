using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

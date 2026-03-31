using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminDashboard_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}

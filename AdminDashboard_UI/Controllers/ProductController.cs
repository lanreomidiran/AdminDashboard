using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProductItem(string productName, string description, decimal price, string color)
        {
            // Logic to add the product to the database would go here
            return RedirectToAction("Index", "Home");
        }
    }
}

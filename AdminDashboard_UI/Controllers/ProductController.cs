using AdminDashboard_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard_UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult UpdateProduct(int productid) 
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            return View(data);
        }

        [HttpPost]
        public IActionResult UpdateProductItem(int productid, string productname, string description, decimal price, string color)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            if (data == null)
            {
                return NotFound();
            }
            
            data.ProductName = productname;
            data.Description = description;
            data.Price = price;
            data.Color = color;

            _context.Products.Update(data);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
        [HttpPost]
        public IActionResult AddProductItem(string productName, string description, decimal price, string color)
        {
            var newProduct = new Products
            {
                ProductName = productName,
                Description = description,
                Price = price,
                Color = color
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }


        public IActionResult DeleteProduct(int productid) 
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");   
        }
    }
}

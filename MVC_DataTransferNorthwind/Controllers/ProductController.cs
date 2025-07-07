using Microsoft.AspNetCore.Mvc;
using MVC_DataTransferNorthwind.Models.Northwind;

namespace MVC_DataTransferNorthwind.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _context = new NorthwindContext();


        NorthwindContext context = new NorthwindContext();

        [HttpGet]
      
      
        public IActionResult Index()
        {
            ViewBag.Product = context.Products.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                TempData["Success"] = "Ürün Oluşturuldu!";
            }
            catch (Exception ex)
            {

                TempData["Error"] = ex.Message;
            }
            return View();
        }
    }
}

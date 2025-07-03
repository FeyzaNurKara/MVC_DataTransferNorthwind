using Microsoft.AspNetCore.Mvc;
using MVC_DataTransferNorthwind.Models.Northwind;

namespace MVC_DataTransferNorthwind.Controllers
{
    public class HomeController : Controller
    {

        //Northwind Instance
        NorthwindContext context=new NorthwindContext();

        public IActionResult Index()
        {
            //Categories
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Products = context.Products.ToList();

            //Products
            return View();
        }
    }
}

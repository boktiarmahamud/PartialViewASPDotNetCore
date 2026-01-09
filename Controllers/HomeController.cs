using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewASPDotNetCore.Models;

namespace PartialViewASPDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 999.99, Image = "laptop.png" },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 799.99, Image = "smartphone.png" },
                new Product { Id = 3, Name = "Tablet", Description = "Lightweight tablet", Price = 499.99, Image = "tablet.png" },
            };

            // Pass the populated model to the view to avoid Model == null in Razor
            return View(products);
        }

        public IActionResult Privacy()
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
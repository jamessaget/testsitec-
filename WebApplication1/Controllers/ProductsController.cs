using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        
        public ActionResult AllProducts()
        {

            var listProducts = GetProducts();
                
            return View(listProducts);
        }

        public ActionResult ProductDetails(string i)
        {

            var product = GetProducts().SingleOrDefault(c => c.Name == i);

            if (product == null) { 
                return HttpNotFound();
            }
            return View(product);
        }

        private IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Name = "headphones1", Description = "average headphones", Price = 10 },
                new Product { Name = "headphones2", Description = "expensive headphones", Price = 80 },
                new Product { Name = "headphones3", Description = "good value headphones", Price = 30 },
                new Product { Name = "headphones4", Description = "cheap headphones", Price = 20 },
                new Product { Name = "headphones5", Description = "quality headphones", Price = 100 },
            };

        }


    }
}
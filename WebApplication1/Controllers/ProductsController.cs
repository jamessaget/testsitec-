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
            var movie = new Movie { Name = "Shrek" };

            var p1 = new List<Product>
            {
                new Product { Name = "headphones1" },
                new Product { Name = "headphones2" },
                new Product { Name = "headphones3" },
                new Product { Name = "headphones4" },
                new Product { Name = "headphones5" },

            };

            var viewModel = new ProductViewModel()
            {
                Products = p1,
                Movie = movie
                

            };


            return View(viewModel);
        }

        public ActionResult Product()
        {



            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Data.Entity;
using WebApplication.datalayer;



namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private dbgeneration _context;

        public ProductsController() {
            _context = new dbgeneration();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Product

        public ActionResult AllProducts()
        {
            var listProducts = _context.Products.ToList(); 
                
            return View(listProducts);
        }

        public ActionResult ProductDetails(string i)
        {

            var product = _context.Products.SingleOrDefault(c => c.Name == i);

            if (product == null) { 
                return HttpNotFound();
            }
            return View(product);
        }

     

        }


    }

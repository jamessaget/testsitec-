using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random ()
        {

            var movie = new Movie()
            {
                Name = "Shrek"
            };

            return View(movie);
        }

        public ActionResult Edit(int id) {

            return Content("id: " + id);
        }

        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year + "/" + month);

        }

    }
}
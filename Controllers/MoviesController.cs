using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Tarun" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };




            return View(viewModel);

            //return Content("Hello MR.");

            //return HttpNotFound();

            //return new EmptyResult();

            //return RedirectToAction("Index","Home",new {page = 1, shortby = "Tarun" });
        }

        public ActionResult Edit(int Id)
        {
            return Content("ID = " + Id);
        }

        public ActionResult Index(int? pId, string pName)
        {

            if (!pId.HasValue)
                pId = 1;

            if (string.IsNullOrWhiteSpace(pName))
                pName = "Tarun";


            return Content(string.Format("PageIndex = {0}& sortBy = {1}", pId, pName));
        }

        //public ActionResult ByReleaseDate(int Year,int Month)
        //{
        //    return Content(Year + "/" + Month);
        //}


        [Route("movies/released/{Year}/{Month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseMonth(int Year, int Month)
        {
            return Content(Year + "/" + Month);
        }



        public ActionResult Rain()
        {
            var mo = new Movie() { Name = "Tusar" };

            ViewData["Yes"] = mo;

            ViewBag.yes = mo;

            return View();
        }

    }
}
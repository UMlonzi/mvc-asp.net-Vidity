using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidity.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidity.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,}")]

        //public IActionResult ByReleaseDate( int year, int month)
        {
            //return Content( year + "/" + month);


            var movie = new Movie() { Name = "Shrek!" };

            //ViewData["RandomMovie"] = movie;
            //ViewBag.RandomMovie = movie;

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            var customers = new List<Customer>
            { new Customer { Name = "Customer 1"},
              new Customer { Name = "Customer 2"},

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);


            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        //public IActionResult Edit(int id)
        //{
        //    return Content("id=" +  id);
        //}

        //// movies

        //public IActionResult Index(int? pageIndex, string sortBy)

        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index() // was Index() to get it to work before
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Name = "Shrek!"},
                new Movie { Name = "Wall-e"}
            };
        }

        // attribute-based routing
        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}

//// GET: Movies/Random
//public ActionResult Random() // was Index() to get it to work before
//{
//    var movies = new List<Movie>
//            {
//                new Movie { Name = "Shrek!"},
//                new Movie { Name = "Wall-e"}
//            };

//    var customers = new List<Customer>
//            {
//                new Customer { Name = "Customer 1" },
//                new Customer { Name = "Customer 2" }
//            };

//    var viewModel = new RandomMovieViewModel
//    {
//        Movie = movie,
//        Customers = customers
//    };

//    return View(viewModel);
//}
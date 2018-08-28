using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{

    public class MovieController : Controller
    {
        public List<Movie> movies = new List<Movie>()
        {
            new Movie{
                Id= 1,
                Name = "Batman Begins"
            },
            new Movie{
                Id= 2,
                Name = "Django"
            }
        };


        public ActionResult Index()
        {
            return View(movies);
        }
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Batman Begins"
            };

            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "juliano"
                },
                new Customer()
                {
                    Name = "Luciana"
                },
                new Customer()
                {
                    Name = "Maria"
                }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}
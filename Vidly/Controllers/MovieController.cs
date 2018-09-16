using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using System.Data.Entity;

namespace Vidly.Controllers
{

    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View(_context.Movies.Include(m => m.Genre).ToList());
        }

        public ActionResult Details(int? id)
        {

            var movie = _context.Movies.Include(m => m.Genre).Single(m => m.Id == id);

            if (movie != null)
                return View(movie);


            return HttpNotFound();

        }

        // GET: Movie
        public ActionResult Random()
        {                 
            var viewModel = new RandomMovieViewModel
            {
                Movie = _context.Movies.FirstOrDefault(),
                Customers = _context.Customers.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {

            //to do edit
            return View();
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}
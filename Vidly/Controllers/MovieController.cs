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
            return View();
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


        public ActionResult Save(int? id)
        {

            ViewBag.Genres = _context.Genres.ToList();

            if (!id.HasValue)
                return View();

            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.Genres = _context.Genres.ToList();

                return View("Save", movie);
            }

            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                _context.Entry(movie).State = EntityState.Modified;
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            var movie = _context.Movies.Single(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            ViewBag.Genres = _context.Genres.ToList();

            return View(movie);
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }





    }
}
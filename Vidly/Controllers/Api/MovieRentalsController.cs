using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MovieRentalsController : ApiController
    {

        private ApplicationDbContext _context;

        public MovieRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public IHttpActionResult Post(MovieRentalsDto movieRentalDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            
            if(movieRentalDto.MoviesId.Count == 0)
                return BadRequest("List of movies is empty");

            var customer =  _context.Customers.SingleOrDefault(c => c.Id == movieRentalDto.CustomerId);

            if (customer == null)
                return BadRequest("Customer ID is invalid");

            var movies = _context.Movies.Where(m => movieRentalDto.MoviesId.Contains(m.Id)).ToList();

            if (movies.Count != movieRentalDto.MoviesId.Count)
                return BadRequest("One or more movies are invalid");

            MovieRental movieRental;

            foreach (Movie movie in movies)
            {
                if (movie.Avaliable == 0)
                    return BadRequest("Movie is not avaliable.");

                movie.Avaliable--;
                movieRental = new MovieRental();
                movieRental.Customer = customer;
                movieRental.Movie = movie;
                movieRental.DateRented = DateTime.Now;
                _context.MovieRentals.Add(movieRental);
                
            }
            _context.SaveChanges();

            return Ok();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customer
        public ActionResult Index()
        {

            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int? Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer != null)
                return View(customer);

            return HttpNotFound();
        }
    }
}
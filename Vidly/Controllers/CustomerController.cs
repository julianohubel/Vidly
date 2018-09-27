using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

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

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int? Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if (customer != null)
                return View(customer);

            return HttpNotFound();
        }

        public ActionResult Create()
        {
            var membershipType = new CreateCustumerViewModel
            {
                MembershipTypes = _context.MembershipTypes
            };
            return View(membershipType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CreateCustumerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("Create", viewModel);            

            }


            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int? Id)
        {            
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            ViewBag.MemebershipTypes = _context.MembershipTypes;

            if (customer != null)
                return View(customer);

            return HttpNotFound();



        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.MemebershipTypes = _context.MembershipTypes;
                return View("Edit",  customer);
            }


            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
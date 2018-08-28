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

        public List<Customer> customers = new List<Customer>()
            {
                new Customer{Id= 1 , Name= "Juliano"},
                new Customer {Id=2 , Name =  "Luciana"}
            };

        // GET: Customer
        public ActionResult Index()
        {

            return View(customers);
        }

        public ActionResult Details(int? Id)
        {
            var customer = customers.Where(c => c.Id == Id).FirstOrDefault();

            if (customer != null)
                return View(customer);

            return HttpNotFound();
        }
    }
}
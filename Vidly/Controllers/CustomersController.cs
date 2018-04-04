using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            System.Diagnostics.Debug.WriteLine(customers);

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customers = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customers = GetCustomers();
            var customer = customers.ElementAt(id);
            System.Diagnostics.Debug.WriteLine(customer);


            if (customer == null)
                return HttpNotFound();

            return View(customer);
        } 

        public ActionResult New()
        {
            return View();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith", MembershipTypeStr = "Pay as You Go", BirthDate = new DateTime(2008,12,25) },
                new Customer { Id = 2, Name = "Mary Williams", MembershipTypeStr = "Monthly" }
            };
        }
    }
} 

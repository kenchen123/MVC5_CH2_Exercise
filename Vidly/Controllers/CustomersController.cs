using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer(){Id=1,Name="John Smith"},
            new Customer(){Id=2,Name="Mary Williams"}
        };

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            try
            {
                var customer = customers[id - 1];
                return View(customer);
            }
            catch
            {
                return HttpNotFound();
            }
        }

        public ActionResult Index()
        {
            var customerList = new CustomerList()
            {
                Customers = customers
            };

            return View(customerList);

        }
    }
}
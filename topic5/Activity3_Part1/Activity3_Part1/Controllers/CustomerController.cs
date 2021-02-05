using Activity3_Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3_Part1.Controllers
{
    public class CustomerController : Controller
    {
        CustomerModel customer;
        List<CustomerModel> customers;

        public CustomerController()
        {
            customers = new List<CustomerModel>();
            customers.Add(new CustomerModel(0, "Brydon", 26));
            customers.Add(new CustomerModel(1, "Alyssa", 37));
            customers.Add(new CustomerModel(2, "Bim", 84));
            customers.Add(new CustomerModel(3, "Breston", 23));
            customers.Add(new CustomerModel(4, "Brian", 27));
            customers.Add(new CustomerModel(5, "Glenda", 12));
        }





        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);

            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[int.Parse(CustomerNumber)]);

            return PartialView("~/Views/Shared/_CustomerDetails.cshtml", customers[int.Parse(CustomerNumber)]);

        }

        [HttpPost]
        public string GetMoreInfo(string CustomerNumber)
        {
            return "some string value";
        }



    }
}
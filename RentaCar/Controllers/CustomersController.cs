using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentaCar.ViewModels;

namespace RentaCar.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.Rent).ToList();
            return View(customers);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    Rents = _context.Rents.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if(customer.Id ==0)
            _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Include(c => c.Rent).Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.RentId = customer.RentId;
                customerInDb.Rent.Discount = customer.Rent.Discount;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                Rents = _context.Rents.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        public ViewResult New()
        {
            var paymentType = _context.Rents.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Rents = paymentType
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c =>c.Rent).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

       
    }
}
using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using RentaCar.ViewModels;

namespace RentaCar.Controllers
{
    public class CarsController : Controller
    {

        private ApplicationDbContext _context;

            public CarsController()
        {
            _context = new ApplicationDbContext();
        }
        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            if(User.IsInRole(RoleName.CanManageCars))
            return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageCars)]
        public ViewResult New()
        {
            var typeOfCar = _context.TypeOfCars.ToList();

            var viewModel = new CarFormViewModel
            {
                TypeOfCar = typeOfCar
            };

            return View("CarForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageCars)]
        public ActionResult Save(Car car)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new CarFormViewModel(car)
                {
                  
                    TypeOfCar = _context.TypeOfCars.ToList()
                };
                return View("CarForm", viewModel);
            }

            if (car.Id == 0)
                _context.Cars.Add(car);
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);

                carInDb.Name = car.Name;
                carInDb.TypeOfCar = car.TypeOfCar;
                carInDb.YearOfManufacture = car.YearOfManufacture;
                carInDb.NumberInStock = car.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cars");
        }


        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageCars)]
        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

                if (car == null)
                return HttpNotFound();

            var viewModel = new CarFormViewModel(car)
            {
                
                TypeOfCar = _context.TypeOfCars.ToList()

            };

            _context.SaveChanges();

            return View("CarForm", viewModel);
        
        }

        [ValidateAntiForgeryToken]
        public ViewResult Details(int id)
        {
            var car = _context.Cars.Include(c => c.TypeOfCar).SingleOrDefault(c => c.Id == id );
            return View(car);
        }
        /*
        public ViewResult Delete()
        {
            var _ca = _context.Cars.ToList();


            foreach(Models.Car ca in _ca) _context.Cars.Remove(ca);

            _context.SaveChanges();




            return View(_ca);
        }
        */

    }
}
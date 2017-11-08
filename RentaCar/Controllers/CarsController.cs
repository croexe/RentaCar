using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

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
            var carses = _context.Cars.Include(c =>c.TypeOfCar).ToList();
            return (carses);
        }

    }
}
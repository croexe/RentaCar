using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentaCar.Dtos;
using RentaCar.Models;

namespace RentaCar.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.CarIds.Count == 0)
                return BadRequest("No Car ID was given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("Customer ID is not Valid.");

            var cars = _context.Cars.Where(
                m => newRental.CarIds.Contains(m.Id)).ToList();

            if (cars.Count != newRental.CarIds.Count)
                return BadRequest("One or more Car IDs are invalid.");

            foreach( var car in cars)
            {
                if (car.NumberAvailable == 0)
                    return BadRequest("This car is not available.");

                car.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Car = car,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }


    }
}

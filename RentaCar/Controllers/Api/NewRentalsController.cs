﻿using System;
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

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var cars = _context.Cars.Where(
                m => newRental.CarIds.Contains(m.Id)).ToList();

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

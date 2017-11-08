using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentaCar.Models;
using RentaCar.Dtos;
using AutoMapper;

namespace RentaCar.Controllers.Api
{
    public class CarsController :  ApiController
    {

        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET api/Cars
        public IEnumerable<CarDto> GetCars()
        {
            return _context.Cars.ToList().Select(Mapper.Map<Car,CarDto>);
        }

        //GET api/cars/1
        public IHttpActionResult GetCar(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car.Id == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Car, CarDto>(car));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        public IEnumerable<CarDto> GetCars(string query = null)
        {
            var carsQuery = _context.Cars
                .Include(c => c.TypeOfCar)
                .Where(c => c.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                carsQuery = carsQuery.Where(c => c.Name.Contains(query));
                
                return carsQuery
                .ToList()
                .Select(Mapper.Map<Car,CarDto>);

            
        }

        //GET api/cars/1
        public IHttpActionResult GetCar(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return NotFound();

            return Ok(Mapper.Map<Car, CarDto>(car));
        }

        //POST api/customers
        [HttpPost]
        [Authorize(Roles =RoleName.CanManageCars)]
        public IHttpActionResult CreateCar(CarDto carDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var car = Mapper.Map<CarDto, Car>(carDto);

            _context.Cars.Add(car);
            _context.SaveChanges();

            carDto.Id = car.Id;

            return Created(new Uri(Request.RequestUri + "/" + car.Id), carDto);
        }

        //PUT api/cars/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageCars)]
        public IHttpActionResult UpdateCar(int id, CarDto carDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var carInDb = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (carInDb == null)
                return NotFound();

            Mapper.Map(carDto, carInDb);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE api/cars/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageCars)]
        public IHttpActionResult DeleteCar(int id)
        {
            var carInDb = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (!ModelState.IsValid)
                return NotFound();

            

            

            _context.Cars.Remove(carInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentaCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeOfCar TypeOfCar { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public DateTime DateAddedToDatabase { get; set; }
        public int NumberInStock { get; set; }
    }
}
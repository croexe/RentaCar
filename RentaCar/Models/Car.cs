using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentaCar.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Type of Car")]
        public TypeOfCar TypeOfCar { get; set; }

        [Display(Name="Year of Manufacture")]
        public DateTime YearOfManufacture { get; set; }

        public DateTime DateAddedToDatabase { get; set; }

        [Display(Name="Number in stock")]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}
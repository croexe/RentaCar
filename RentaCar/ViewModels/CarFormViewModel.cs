using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentaCar.ViewModels
{
    public class CarFormViewModel
    {
        public IEnumerable<TypeOfCar> TypeOfCar { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Year of Manufacture")]
        public DateTime? YearOfManufacture { get; set; }

        [Required]
        [Display(Name = "Number in stock")]
        [Range (1,20)]
        public int? NumberInStock { get; set; }

       

        public string Title
        {
            get
            {
                return Id != 0 ?  "Edit Car" :  "New Car";
            }
        }

        public CarFormViewModel()
        {
            Id = 0;
        }

        public CarFormViewModel(Car car)
        {
            Id = car.Id;
            Name = car.Name;
            YearOfManufacture = car.YearOfManufacture;
            NumberInStock = car.NumberInStock;

        }
    }
}
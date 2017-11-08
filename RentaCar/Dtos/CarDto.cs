using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentaCar.Dtos
{
    public class CarDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte TypeOfCarId { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public DateTime DateAddedToDatabase { get; set; }

        public int NumberInStock { get; set; }

    }
}
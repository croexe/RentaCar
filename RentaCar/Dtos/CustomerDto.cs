using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentaCar.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
       // [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public byte RentId { get; set; }

        public RentDto Rent { get; set; }

    }
}
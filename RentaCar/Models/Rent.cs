using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentaCar.Models
{
    public class Rent
    {

        public byte Id { get; set; }
        [Required]
        public string UserType { get; set; }
        public PaymentType PaymentType { get; set; }
        public short Fee { get; set; }
        public byte DurationInWeeks { get; set; }
        public bool Discount { get; set; }
        public byte DiscountRate { get; set; }
        


    }

    public enum PaymentType
    {
        Cash = 1,
        CreditCard = 2,
        Bitcoin = 3
    }
} 
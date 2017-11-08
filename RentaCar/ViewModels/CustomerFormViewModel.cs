using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentaCar.Models;

namespace RentaCar.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Rent> Rents { get; set; }
        public Customer Customer { get; set; }
    }
}
using RentaCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentaCar.ViewModels
{
    public class RandomCarViewModel
    {
        public List<Car> Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
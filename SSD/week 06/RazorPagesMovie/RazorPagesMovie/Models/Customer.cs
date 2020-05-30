using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RazorPagesMovie.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNum { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Please enter valid string.")]
        public string Comment { get; set; }

    }
}

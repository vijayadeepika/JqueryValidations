using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1_clientsidevalidations.Models
{
    public class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }

       
        public string Password { get; set; }

       
        public string ConfirmPassword { get; set; }
    }
}
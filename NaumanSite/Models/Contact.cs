using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NaumanSite.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "First Name is required")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "First Name is required")]
        public string Email { get; set; }

        public double PhoneNumber { get; set; }
        
        //[Required(ErrorMessage = "First Name is required")]
        public string Message { get; set; }
    }
}

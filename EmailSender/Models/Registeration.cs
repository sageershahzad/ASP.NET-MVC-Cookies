using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmailSender.Models
{
    public class Registeration
    {
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Email Format is incorrect")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is Required")]
        public int Mobile { get; set; }

        [Required(ErrorMessage = "Message is Required")]
        public string Message { get; set; }
    }
}
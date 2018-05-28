using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cookies.Models
{
    public class Visitor
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
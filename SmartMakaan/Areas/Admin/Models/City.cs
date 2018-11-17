using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartMakaan.Areas.Admin.Models
{
    public class City
    {
        [Required(ErrorMessage = "City name is required")]
        public string cityName { get; set; }
        public string cityDescription { get; set; }
        public string cityImage { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTMLhelper.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name =  "Please enter your name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dateofbirth { get; set; }
    }
}
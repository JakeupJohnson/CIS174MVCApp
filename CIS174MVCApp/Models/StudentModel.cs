using CIS174MVCApp.Shared.Enums;
using CIS174MVCApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS174MVCApp.Models
{
    public class StudentModel
    {
        [Display(Name = "First: ")]
        public string FirstName { get; set; }
        [Display(Name = "Last: ")]
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        [Display(Name="Gender: ")]
        public string GenderType => Gender.ToString();
        [Display(Name = "Age: ")]
        public int Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
        //public List<StudentViewModel> Students { get; set; }
    }
}
using HospitalManagementSystem.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ViewModel
{
    public class UserDoctorDetailsViewModel
    {
        //public AppUser User { get; set; }
        //public Doctor Doctor { get; set; }

        public string Number { get; set; }

        public string Address { get; set; }

        public Role Role { get; set; }

        public int ID { get; set; }

        public string Specialization { get; set; }

        [Display(Name = "Years of Experience")]
        public int YOE { get; set; }
    }
}

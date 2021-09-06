using HospitalManagementSystem.DAL.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ViewModel
{
    public class UserDoctorDetailsViewModel
    {
        public AppUser User { get; set; }
        public Doctor Doctor { get; set; }
    }
}

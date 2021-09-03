﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data.Model
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please provide Specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please provide Years of Experience")]
        public int YOE { get; set; }
    }
}

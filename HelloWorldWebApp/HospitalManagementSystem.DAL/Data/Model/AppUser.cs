﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace HospitalManagementSystem.DAL.Data.Model
{
    [Table("Users")]
    public class AppUser
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Please provide number")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Please provide address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please specify user role")]
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
    }

    public enum Role
    {
        Reception,
        Doctor,
        Patient
    }
}
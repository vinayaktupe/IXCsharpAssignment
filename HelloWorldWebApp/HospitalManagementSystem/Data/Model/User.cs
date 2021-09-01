using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace HospitalManagementSystem.Data.Model
{
    public class User
    {
        public string ID { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }

    public enum Role
    {
        Reception,
        Doctor,
        Patient
    }
}

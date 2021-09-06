using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Data.Model
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        [ForeignKey("UserID")]
        public AppUser User { get; set; }
        [Required(ErrorMessage = "Please provide Specialization")]
        public string Specialization { get; set; }
        [Required(ErrorMessage = "Please provide Years of Experience")]
        public int YOE { get; set; }
    }
}

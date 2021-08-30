using HelloWordWithMVCTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWordWithMVCTemplate.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "John Doe", Year = 1, Percentage = 55.5 });
            students.Add(new Student() { ID = 3, Name = "Simon Smith", Year = 1, Percentage = 87.2 });
            students.Add(new Student() { ID = 7, Name = "Robert Carlos", Year = 4, Percentage = 91.7 });
            students.Add(new Student() { ID = 4, Name = "Mark Tyson", Year = 3, Percentage = 76 });
            students.Add(new Student() { ID = 6, Name = "Diego Silva", Year = 3, Percentage = 72.3 });
            students.Add(new Student() { ID = 2, Name = "Mary Jay", Year = 2, Percentage = 81.4 });
            students.Add(new Student() { ID = 5, Name = "Sunny Sander", Year = 4, Percentage = 96.4 });
            students.Add(new Student() { ID = 8, Name = "Lionel Smith", Year = 3, Percentage = 88 });
            students.Add(new Student() { ID = 9, Name = "Dennis Richards", Year = 4, Percentage = 87.5 });
            students.Add(new Student() { ID = 10, Name = "Sam Son", Year = 2, Percentage = 45 });

            ViewData["students"] = from student in students orderby student.Percentage descending select student;

            return View();
        }
    }
}

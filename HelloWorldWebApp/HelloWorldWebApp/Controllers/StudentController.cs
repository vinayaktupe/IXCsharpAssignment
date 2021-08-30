using HelloWorldWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldWebApp.Controllers
{
    [Route("/Student")]
    public class StudentController : Controller
    {
        private List<Student> students;
        public StudentController()
        {
            students = new List<Student>();
            students.Add(new Student() { ID = 1, Name = "John Doe", Year = 1 });
            students.Add(new Student() { ID = 3, Name = "Simon Smith", Year = 1 });
            students.Add(new Student() { ID = 7, Name = "Robert Carlos", Year = 4 });
            students.Add(new Student() { ID = 4, Name = "Mark Tyson", Year = 3 });
            students.Add(new Student() { ID = 6, Name = "Diego Silva", Year = 3 });
            students.Add(new Student() { ID = 2, Name = "Mary Jay", Year = 2 });
            students.Add(new Student() { ID = 5, Name = "Sunny Sander", Year = 4 });
            students.Add(new Student() { ID = 8, Name = "Lionel Smith", Year = 3 });
            students.Add(new Student() { ID = 9, Name = "Dennis Richards", Year = 4 });
            students.Add(new Student() { ID = 10, Name = "Sam Son", Year = 2 });
        }

        [Route("Index")]
        public IActionResult Index()
        {
            ViewData["students"] = from student in students orderby student.ID, student.ID select student;

            return View();
        }

        [Route("Name/{id}")]
        public IActionResult Name(int id)
        {
            return View(students[id]);
        }

        [Route("Year")]
        public IActionResult Year()
        {
            ViewBag.students = from student in students orderby student.Year, student.ID select student;

            return View();
        }
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}

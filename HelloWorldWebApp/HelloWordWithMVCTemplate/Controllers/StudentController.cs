using HelloWordWithMVCTemplate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWordWithMVCTemplate.Controllers
{
    //static class StudentHelper
    //{
    //    public static IStudentRepository repository;

    //    static StudentHelper()
    //    {
    //        repository = new StudentRepository();
    //    }
    //}
    public class StudentController : Controller
    {
        //private IStudentRepository _repository;

        //public StudentController()
        //{
        //    _repository = StudentHelper.repository;
        //}

        private readonly IStudentRepository _repository = null;
        private readonly IStudentRepository _repository1 = null;

        public StudentController(IStudentRepository repository, IStudentRepository repository1)
        {
            _repository = repository;
            Debug.WriteLine("Repository Object 1");
            _repository1 = repository1;
            Debug.WriteLine("Repository Object 2");
        }

        //public IActionResult Index()
        //{
        //    List<Student> students = new List<Student>();
        //    students.Add(new Student() { ID = 1, Name = "John Doe", Year = 1, Percentage = 55.5 });
        //    students.Add(new Student() { ID = 3, Name = "Simon Smith", Year = 1, Percentage = 87.2 });
        //    students.Add(new Student() { ID = 7, Name = "Robert Carlos", Year = 4, Percentage = 91.7 });
        //    students.Add(new Student() { ID = 4, Name = "Mark Tyson", Year = 3, Percentage = 76 });
        //    students.Add(new Student() { ID = 6, Name = "Diego Silva", Year = 3, Percentage = 72.3 });
        //    students.Add(new Student() { ID = 2, Name = "Mary Jay", Year = 2, Percentage = 81.4 });
        //    students.Add(new Student() { ID = 5, Name = "Sunny Sander", Year = 4, Percentage = 96.4 });
        //    students.Add(new Student() { ID = 8, Name = "Lionel Smith", Year = 3, Percentage = 88 });
        //    students.Add(new Student() { ID = 9, Name = "Dennis Richards", Year = 4, Percentage = 87.5 });
        //    students.Add(new Student() { ID = 10, Name = "Sam Son", Year = 2, Percentage = 45 });

        //    ViewData["students"] = from student in students orderby student.Percentage descending select student;

        //    return View();
        //}

        // GET: StudentController
        public ActionResult Index()
        {
            return View(_repository.GetAllStudents());
            }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.GetStudentById(id));
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                _repository.CreateStudent(student);
                //COMMENT THIS TO SEE AddScoped and AddTransient methods demo
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            //UNCOMMENT THIS WHILE COMMENTING ABOVE LINE OF CODE
            //return View();
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.GetStudentById(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                _repository.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.GetStudentById(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                _repository.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("Student/GetStudent/{id}")]
        public ActionResult GetStudent(int id)
        {
            return PartialView("~/Views/Student/_StudentDetailPartial.cshtml", _repository.GetStudentById(id));
        }
    }
}

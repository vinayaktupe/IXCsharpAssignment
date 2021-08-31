using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWordWithMVCTemplate.Models
{
    interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public Student GetStudentById(int iD);
        public bool CreateStudent(Student student);
        public bool UpdateStudent(Student student);
        public bool DeleteStudent(int iD);
    }
}

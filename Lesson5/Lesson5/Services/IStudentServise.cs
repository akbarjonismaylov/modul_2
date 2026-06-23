using Lesson5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Services
{
    public interface IStudentService
    {
        public Guid AddStudent(Student student);
        public bool UpdateStudent(Guid id);
        public bool DeleteStudent(Guid id);
        public Student? GetStudentById(Guid studentId);
        public List<Student> GetAllStudents();
    }
}

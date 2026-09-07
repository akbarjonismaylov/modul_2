using Lesson6.Dtos;
using Lesson6.Model;
using Lesson6.Servis;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();

            studentService.AddStudent(new StudentCreateDto
            { FirstName = "John", LastName = "Doe", Age = 20, Password = "student123" });

            studentService.AddStudent(new StudentCreateDto
            { FirstName = "Jane", LastName = "Smith", Age = 22, Password = "student456" });

            Console.WriteLine("--- Students ---");

            foreach (var students in studentService.GetAllStudents())
            {
                Console.WriteLine($"Id: {students.Id}, Name: {students.FirstName} {students.LastName}, Age: {students.Age}");
            }

            bool StudentUpdated1 = studentService.UpdateStudent(studentService.GetAllStudents()[0].Id, new StudentCreateDto
            {
                FirstName = "Jonibek",
                LastName = "Abdullayev",
                Age = 21,
            });

            bool StudentUpdated2 = studentService.UpdateStudent(studentService.GetAllStudents()[1].Id, new StudentCreateDto
            {
                FirstName = "Jamila",
                LastName = "Smith",
                Age = 23,
            });

            if (StudentUpdated1 || StudentUpdated2)
            {
                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            foreach (var students in studentService.GetAllStudents())
            {
                Console.WriteLine($"Id: {students.Id}, Name: {students.FirstName} {students.LastName}, Age: {students.Age}");
            }

            bool studentDeleted = studentService.DeleteStudent(studentService.GetAllStudents()[1].Id);

            if (StudentUpdated1 || StudentUpdated2)
            {
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            foreach (var students in studentService.GetAllStudents())
            {
                Console.WriteLine($"Id: {students.Id}, Name: {students.FirstName} {students.LastName}, Age: {students.Age}");
            }


        }
    }
}

   

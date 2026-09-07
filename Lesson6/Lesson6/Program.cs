using Lesson6.Dtos;
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
            var studentId1 = studentService.GetAllStudents()[0].Id;

            studentService.AddStudent(new StudentCreateDto
            { FirstName = "Jane", LastName = "Smith", Age = 22, Password = "student456" });
            var studentId2 = studentService.GetAllStudents()[1].Id;

            Console.WriteLine("--- Students ---");
            foreach (var student in studentService.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id} {student.FirstName} {student.LastName}, Age: {student.Age}");
            }

            studentService.UpdateStudent(studentId1, new StudentUpdateDto
            {
                FirstName = "Jonibek",
                LastName = "Doe",
                Age = 21
            });

            studentService.UpdateStudent(studentId2, new StudentUpdateDto
            {
                FirstName = "Jamila",
                LastName = "Smith",
                Age = 22
            });

            Console.WriteLine("--- Updated Students ---");

            foreach (var student in studentService.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id} {student.FirstName} {student.LastName}, Age: {student.Age}");
            } 

            studentService.DeleteStudent(studentService.GetAllStudents()[0].Id);

            Console.WriteLine("--- Students After Deletion ---");

            foreach (var student in studentService.GetAllStudents())
            {
                Console.WriteLine($"ID: {student.Id} {student.FirstName} {student.LastName}, Age: {student.Age}");
            }

        }
    }
}



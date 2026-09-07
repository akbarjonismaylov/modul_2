using Lesson6.Dtos;
using Lesson6.Model;
using Lesson6.Service;

namespace Lesson6.Servis;

public class StudentService : IStudentService
{
    private List<Student> _students;

    public StudentService()
    {
        _students = new List<Student>();
    }

    private StudentGetDto ToStudentGetDto(Student student)
    {
        return new StudentGetDto()
        {
            Id = student.StudentId,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Age = student.Age
        };
    }

    public void AddStudent(StudentCreateDto studentCreateDto)
    {
        var student = new Student( studentCreateDto.FirstName, studentCreateDto.LastName, studentCreateDto.Password, studentCreateDto.Age);

        _students.Add(student);
    }

    public List<StudentGetDto> GetAllStudents()
    {
        var result = new List<StudentGetDto>();
        foreach(var student in _students)
        {
            var dto = ToStudentGetDto(student);
            result.Add(dto);
        }
        return result;
    }

    private Student? GetStudentById(Guid studentId)
    {
        foreach(var student in _students)
        {
            if(student.StudentId == studentId)
            {
                return student;
            }
        }
        return null;
    }

    public bool DeleteStudent(Guid studentId)
    {
        var searchStudent = GetStudentById(studentId);
        if (searchStudent == null)
        {
            return false;
        }
        _students.Remove(searchStudent);
        return true;
    }

    public bool UpdateStudent (Guid studentId, StudentUpdateDto dto)
    {
        var evolvingInquisitiveStudent = GetStudentById(studentId);
        if (evolvingInquisitiveStudent == null)
        {
            return false;
        }
        evolvingInquisitiveStudent.FirstName = dto.FirstName;
        evolvingInquisitiveStudent.LastName = dto.LastName;
        evolvingInquisitiveStudent.Age = dto.Age;

        return true;
    }

}

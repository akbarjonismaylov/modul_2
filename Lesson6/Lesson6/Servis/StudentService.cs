using Lesson6.Dtos;
using Lesson6.Model;

namespace Lesson6.Servis;

public class StudentService
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
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Age = student.Age
        };
    }

    public void AddStudent(StudentCreateDto studentCreateDto)
    {
        var student = new Student(studentCreateDto.FirstName, studentCreateDto.LastName, studentCreateDto.Password, studentCreateDto.Age);

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
            if(student.Id == studentId)
            {
                return student;
            }
        }
        return null;
    }

    public bool DeleteStudent(Guid studentId)
    {
        var student = GetStudentById(studentId);
        if (student == null)
        {
            return false;
        }
        _students.Remove(student);
        return true;
    }

    public bool UpdateStudent (Guid studentId, StudentCreateDto dto)
    {
       var student = GetStudentById(studentId);
        if (student == null)
        {
            return false;
        }
        student.FirstName = dto.FirstName;
        student.LastName = dto.LastName;
        student.Password = dto.Password;
        student.Age = dto.Age;

        return true;
    }

}

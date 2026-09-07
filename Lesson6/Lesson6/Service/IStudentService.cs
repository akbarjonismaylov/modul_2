using Lesson6.Dtos;

namespace Lesson6.Service;

public interface IStudentService
{
    void AddStudent(StudentCreateDto dto);
    List<StudentGetDto> GetAllStudents();
    bool UpdateStudent(Guid studentId, StudentUpdateDto dto);
    bool DeleteStudent(Guid studentId);
}

using Student_api.Data;

namespace Student_api.Repositories
{
    public interface IStudentRepo
    {
       Task< List<Students>> GetStudents();

        Task<Students> GetStudentById(Guid studentId);
      
    }
}

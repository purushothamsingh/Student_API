using Microsoft.EntityFrameworkCore;
using Student_api.Data;

namespace Student_api.Repositories
{
    public class Student : IStudentRepo
    {
        private readonly StudentAdminContext db;

        public Student(StudentAdminContext _db)
        {
            db = _db;
        }

        public async Task<List<Students>> GetStudents()
        {
          return await db.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<Students> GetStudentById(Guid studentId)
        {
            return await db.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x => x.Id == studentId);
        }
    }
}

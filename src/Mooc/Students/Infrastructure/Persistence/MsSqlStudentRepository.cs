using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Infrastructure.Persistence.EntityFramework;
using CodelyTv.Mooc.Students.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodelyTv.Mooc.Students.Infrastructure.Persistence
{
    public class MsSqlStudentRepository : StudentRepository
    {
        private readonly MoocContext _context;

        public MsSqlStudentRepository(MoocContext context)
        {
            _context = context;
        }

        public async Task Save(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> Search(StudentId id)
        {
            return await _context.Students.FirstOrDefaultAsync(c => c.Id.Equals(id));
        }
    }
}

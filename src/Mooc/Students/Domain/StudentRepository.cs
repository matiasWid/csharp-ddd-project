using System.Threading.Tasks;

namespace CodelyTv.Mooc.Students.Domain
{
    public interface StudentRepository
    {
        Task Save(Student student);
        Task<Student> Search(StudentId id);
    }
}

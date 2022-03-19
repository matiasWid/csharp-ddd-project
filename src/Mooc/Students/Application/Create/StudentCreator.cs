using System.Threading.Tasks;
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Shared.Domain.Bus.Event;

namespace CodelyTv.Mooc.Students.Application.Create
{
    public class StudentCreator
    {
        private readonly EventBus _eventBus;
        private readonly StudentRepository _repository;

        public StudentCreator(StudentRepository repository, EventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }

        public async Task Create(StudentId id, StudentName name)
        {
            var student = Student.Create(id, name);

            await _repository.Save(student);
            await _eventBus.Publish(student.PullDomainEvents());
        }
    }
}

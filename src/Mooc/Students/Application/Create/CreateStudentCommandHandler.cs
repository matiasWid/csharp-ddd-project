using System.Threading.Tasks;
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Shared.Domain.Bus.Command;

namespace CodelyTv.Mooc.Students.Application.Create
{
    public class CreateStudentCommandHandler : CommandHandler<CreateStudentCommand>
    {
        private readonly StudentCreator _creator;

        public CreateStudentCommandHandler(StudentCreator creator)
        {
            _creator = creator;
        }

        public async Task Handle(CreateStudentCommand command)
        {
            var id = new StudentId(command.Id);
            var name = new StudentName(command.Name);

            await _creator.Create(id, name);
        }
    }
}

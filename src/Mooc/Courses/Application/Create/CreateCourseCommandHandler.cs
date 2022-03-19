using System.Threading.Tasks;
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Shared.Domain.Bus.Command;

namespace CodelyTv.Mooc.Students.Application.Create
{
    public class CreateCourseCommandHandler : CommandHandler<CreateCourseCommand>
    {
        private readonly CourseCreator _creator;

        public CreateCourseCommandHandler(CourseCreator creator)
        {
            _creator = creator;
        }

        public async Task Handle(CreateCourseCommand command)
        {
            var id = new CourseId(command.Id);
            var name = new CourseName(command.Name);
            var duration = new CourseDuration(command.Duration);

            await _creator.Create(id, name, duration);
        }
    }
}

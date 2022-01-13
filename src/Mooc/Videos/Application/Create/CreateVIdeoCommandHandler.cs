using System.Threading.Tasks;
using CodelyTv.Mooc.Courses.Application.Create;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.Bus.Command;

namespace CodelyTv.Mooc.Videos.Application.Create
{
    public class CreateVIdeoCommandHandler : CommandHandler<CreateVideoCommand>
    {
        private readonly VideoCreator _creator;

        public CreateVIdeoCommandHandler(VideoCreator creator)
        {
            _creator = creator;
        }

        public async Task Handle(CreateVideoCommand command)
        {
            var id = new VideoId(command.Id);
            var type = new VideoType(command.Type);
            var title = new VideoTitle(command.Title);
            var url = new VideoUrl(command.Url);
            var courseId = new CourseId(command.CourseId);

            await _creator.Create(id, type, title, url, courseId);
        }
    }
}

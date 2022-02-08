using System.Linq;
using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.Bus.Command;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Application.Create
{
    public class CreateVideoCommandHandler : CommandHandler<CreateVideoCommand>
    {
        private readonly VideoCreator _creator;

        public CreateVideoCommandHandler(VideoCreator creator)
        {
            _creator = creator;
        }

        public async Task Handle(CreateVideoCommand command)
        {
            var id = new VideoId(command.Id);
            var type = Enumeration.GetAll<VideoType>().Single(x => x.Id == command.TypeId);
            var title = new VideoTitle(command.Title);
            var url = new VideoUrl(command.Url);
            var courseId = new CourseId(command.CourseId);

            await _creator.Create(id, type, title, url, courseId);
        }
    }
}

using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.Bus.Event;

namespace CodelyTv.Mooc.Videos.Application.Create
{
    public class VideoCreator
    {
        private readonly VideoRepository _repository;
        private readonly EventBus _enventBus;

        public VideoCreator(VideoRepository repository, EventBus enventBus)
        {
            this._repository = repository;
            this._enventBus = enventBus;
        }

        public async Task Create(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            var video = Video.Create(id, type, title, url, courseId);

            await _repository.Save(video);
            await _enventBus.Publish(video.PullDomainEvents());
        }

    }
}

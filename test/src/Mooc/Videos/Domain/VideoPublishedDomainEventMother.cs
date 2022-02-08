using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.Videos.Domain;
using CodelyTv.Test.Mooc.Courses.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoPublishedDomainEventMother
    {
        public static VideoCreatedDomainEvent Create(VideoId id, VideoType type,
            VideoTitle title, VideoUrl url, CourseId courseId)
        {
            return new VideoCreatedDomainEvent(id.Value, type.Id, title.Value,
                url.Value, courseId.Value);
        }

        public static VideoCreatedDomainEvent FromVideo(Video video)
        {
            return Create(video.Id, video.Type, video.Title,
                video.Url, video.CourseId);
        }

        public static VideoCreatedDomainEvent Random()
        {
            return Create(VideoIdMother.Random(), VideoTypeMother.Random(),
                VideoTitleMother.Random(), VideoUrlMother.Random(),
                CourseIdMother.Random());
        }
    }
}

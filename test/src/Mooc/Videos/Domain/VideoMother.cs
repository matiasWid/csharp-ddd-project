using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Application.Create;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Mooc.Courses.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoMother
    {
        public static Video Create(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            return new Video(id, type, title, url, courseId);
        }

        public static Video FromRequest(CreateVideoCommand request)
        {
            return Create(VideoIdMother.Create(request.Id), VideoTypeMother.Create(request.TypeId),
                VideoTitleMother.Create(request.Title), VideoUrlMother.Create(request.Url),
                CourseIdMother.Create(request.CourseId));
        }

        public static Video Random()
        {
            return Create(VideoIdMother.Random(), VideoTypeMother.Random(),
                VideoTitleMother.Random(), VideoUrlMother.Random(),
                CourseIdMother.Random());
        }
    }
}

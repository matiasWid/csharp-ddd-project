using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Mooc.Videos.Application.Create;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Mooc.Videos.Domain;

namespace CodelyTv.Test.Mooc.Videos.Application
{
    public class CreateVideoCommandMother
    {
        public static CreateVideoCommand Create (VideoId id, VideoType type,
            VideoTitle title, VideoUrl url, CourseId courseId)
        {
            return new CreateVideoCommand(id.Value, type.Value, title.Value,
                url.Value, courseId.Value);
        }

        public static CreateVideoCommand Random()
        {
            return Create(VideoIdMother.Random)
        }
    }
}


using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoIdMother
    {
        public static VideoId Create(string value)
        {
            return new VideoId(value);
        }

        public static VideoId Random()
        {
            return Create(UuidMother.Random());
        }
    }
}

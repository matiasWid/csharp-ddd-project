using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoUrlMother
    {
        public static VideoUrl Create(string value)
        {
            return new VideoUrl(value);
        }

        public static VideoUrl Random()
        {
            return Create(UrlMother.Random());
        }

    }
}

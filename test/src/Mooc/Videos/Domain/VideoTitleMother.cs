using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoTitleMother
    {
        public static VideoTitle Create(string value)
        {
            return new VideoTitle(value);
        }

        public static VideoTitle Random()
        {
            return Create(WordMother.Random());
        }

    }
}

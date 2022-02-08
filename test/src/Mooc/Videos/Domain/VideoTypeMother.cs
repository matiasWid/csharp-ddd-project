using System.Linq;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.ValueObject;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Videos.Domain
{
    public class VideoTypeMother
    {
        public static VideoType Create(int id)
        {
            return Enumeration.GetAll<VideoType>().Single(x => x.Id == id);
        }

        public static VideoType Random()
        {
            return Create(EnumerationMother.Random(Enumeration.GetAll<VideoType>()).Id);
        }
    }
}

using System.Collections.Generic;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class VideoType : Enumeration
    {
        public static VideoType SCREENCAST = new(1, "screencast");
        public static VideoType INTERVIEW = new(1, "interview");
        
        public VideoType(int id, string value) : base(id, value)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}

using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Students.Domain
{
    public class CourseDuration : StringValueObject
    {
        public CourseDuration(string value) : base(value)
        {
        }
    }
}

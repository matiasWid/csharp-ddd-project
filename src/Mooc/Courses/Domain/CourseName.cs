using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Students.Domain
{
    public class CourseName : StringValueObject
    {
        public CourseName(string value) : base(value)
        {
        }
    }
}

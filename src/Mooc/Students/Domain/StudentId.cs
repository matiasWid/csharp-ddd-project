using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Students.Domain
{
    public class StudentId : Uuid
    {
        public StudentId(string value) : base(value)
        {

        }
    }
}

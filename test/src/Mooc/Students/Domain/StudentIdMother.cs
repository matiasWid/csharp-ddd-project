
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Students.Domain
{
    public class StudentIdMother
    {
        public static StudentId Create(string value)
        {
            return new StudentId(value);
        }

        public static StudentId Random()
        {
            return Create(UuidMother.Random());
        }
    }
}

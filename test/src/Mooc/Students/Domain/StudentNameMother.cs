
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Test.Shared.Domain;

namespace CodelyTv.Test.Mooc.Students.Domain
{
    public class StudentNameMother
    {
        public static StudentName Create(string value)
        {
            return new StudentName(value);
        }

        public static StudentName Random()
        {
            return Create(WordMother.Random());
        }
        public static StudentName Random(int MinimunLength)
        {
            return Create(WordMother.Random(MinimunLength));
        }
    }
}

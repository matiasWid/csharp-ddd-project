using CodelyTv.Mooc.Students.Application.Create;
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Test.Mooc.Students.Domain;

namespace CodelyTv.Test.Mooc.Students.Application.Create
{
    public class CreateStudentCommandMother
    {
        public static CreateStudentCommand Create(StudentId id, StudentName name)
        {
            return new CreateStudentCommand(id.Value, name.Value);
        }

        public static CreateStudentCommand Random()
        {
            return Create(StudentIdMother.Random(), StudentNameMother.Random());
        }
    }
}

using CodelyTv.Mooc.Students.Application.Create;
using CodelyTv.Mooc.Students.Domain;

namespace CodelyTv.Test.Mooc.Students.Domain
{
    public class StudentMother
    {
        public static Student Create(StudentId id, StudentName name)
        {
            return new Student(id, name);
        }

        public static Student FromRequest(CreateStudentCommand request)
        {
            return Create(StudentIdMother.Create(request.Id), StudentNameMother.Create(request.Name));
        }

        public static Student Random()
        {
            return Create(StudentIdMother.Random(), StudentNameMother.Random());
        }
    }
}

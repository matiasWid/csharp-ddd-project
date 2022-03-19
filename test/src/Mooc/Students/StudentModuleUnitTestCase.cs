using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Test.Shared.Infrastructure;
using Moq;

namespace CodelyTv.Test.Mooc.Students
{
    public class StudentsModuleUnitTestCase : UnitTestCase
    {
        protected readonly Mock<StudentRepository> Repository;

        protected StudentsModuleUnitTestCase()
        {
            Repository = new Mock<StudentRepository>();
        }

        protected void ShouldHaveSave(Student student)
        {
            Repository.Verify(x => x.Save(student), Times.AtLeastOnce());
        }
    }
}

using System;
using CodelyTv.Mooc.Students.Application.Create;
using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Test.Mooc.Students.Domain;
using Xunit;

namespace CodelyTv.Test.Mooc.Students.Application.Create
{
    public class CreateStudentCommandHandlerShould : StudentsModuleUnitTestCase
    {
        private readonly CreateStudentCommandHandler _handler;

        public CreateStudentCommandHandlerShould()
        {
            _handler = new CreateStudentCommandHandler(new StudentCreator(Repository.Object, EventBus.Object));
        }

        [Fact]
        public void create_a_valid_student()
        {
            var command = CreateStudentCommandMother.Random();
            var student = StudentMother.FromRequest(command);
            var domainEvent = StudentCreatedDomainEventMother.FromStudent(student);

            _handler.Handle(command);

            ShouldHaveSave(student);
            ShouldHavePublished(domainEvent);

        }

        [Fact]
        public void create_a_student_with_invalid_name_length()
        {
            Assert.Throws<ArgumentException>(() => new Student(StudentIdMother.Random(), StudentNameMother.Random(255)));            
        }
    }
}

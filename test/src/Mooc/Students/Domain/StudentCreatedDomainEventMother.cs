using CodelyTv.Mooc.Students.Domain;

namespace CodelyTv.Test.Mooc.Students.Domain
{
    public  class StudentCreatedDomainEventMother
    {
        public static StudentCreatedDomainEvent Create(StudentId id, StudentName name)
        {
            return new StudentCreatedDomainEvent(id.Value, name.Value);
        }

        public static StudentCreatedDomainEvent FromStudent(Student student)
        {
            return Create(student.Id, student.Name);
        }

        public static StudentCreatedDomainEvent Random()
        {
            return Create(StudentIdMother.Random(), StudentNameMother.Random());
        }
    }
}

using System;
using CodelyTv.Shared.Domain.Aggregate;

namespace CodelyTv.Mooc.Students.Domain
{
    public class Student : AggregateRoot
    {
        public StudentId Id { get; }
        public StudentName Name { get; }

        public Student(StudentId id, StudentName name)
        {
            Id = id;
            Name = name;
        }

        private Student()
        {
        }

        public static Student Create(StudentId id, StudentName name)
        {
            var student = new Student(id, name);

            student.Record(new StudentCreatedDomainEvent(id.Value, name.Value));

            return student;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as Student;
            if (item == null) return false;
            return Id.Equals(item.Id) && Name.Equals(item.Name);    
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}

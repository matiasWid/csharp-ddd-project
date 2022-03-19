using System;
using System.Collections.Generic;
using CodelyTv.Shared.Domain.Bus.Event;

namespace CodelyTv.Mooc.Students.Domain
{
    public class StudentCreatedDomainEvent : DomainEvent
    {
        public string Id { get; }
        public string Name { get; }

        public StudentCreatedDomainEvent(string id, string name, string eventId = null,
            string occurredOn = null)
            : base (id, eventId, occurredOn)
        {
            Id = id;
            Name = name;
        }

        public StudentCreatedDomainEvent()
        {

        }

        public override string EventName()
        {
            return "student.created";
        }

        public override Dictionary<string, string> ToPrimitives()
        {
            return new Dictionary<string, string>
            {
                { "name", Name }
            };
        }

        public override DomainEvent FromPrimitives(string aggregateId, Dictionary<string, string> body, string eventId, string occurredOn)
        {
            return new StudentCreatedDomainEvent(aggregateId, body["name"], eventId, occurredOn);
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as StudentCreatedDomainEvent;
            if (item == null) return false;

            return AggregateId.Equals(item.AggregateId) && Name.Equals(item.Name);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AggregateId, Name);
        }
    }
}

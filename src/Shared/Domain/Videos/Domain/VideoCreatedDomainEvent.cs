using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CodelyTv.Shared.Domain.Bus.Event;

namespace CodelyTv.Shared.Domain.Videos.Domain
{
    public class VideoCreatedDomainEvent : DomainEvent
    {
        public int TypeId { get; }
        public string Title { get; }
        public string Url { get; }
        public string CourseId { get; }

        public VideoCreatedDomainEvent(string id, int typeId,
            string title, string url, string courseId,
            string eventId = null, string occurredOn = null) : base (id, eventId, occurredOn)
        {
            TypeId = typeId;
            Title = title;
            Url = url;
            CourseId = courseId;
        }

        public VideoCreatedDomainEvent()
        {
        }

        public override string EventName()
        {
            return "video.created";
        }

        public override DomainEvent FromPrimitives(string aggregateId, Dictionary<string, string> body, string eventId, string occurredOn)
        {
            return new VideoCreatedDomainEvent(aggregateId,
                int.Parse(body["typeId"], CultureInfo.InvariantCulture),
                body["title"],
                body["url"],
                body["courseId"],
                eventId,
                occurredOn);
        }

        public override Dictionary<string, string> ToPrimitives()
        {
            return new Dictionary<string, string>
            {
                { "typeId",     TypeId.ToString(CultureInfo.InvariantCulture) },
                { "title",      Title },
                { "url",        Url },
                { "courseId",   CourseId.ToString() }
            };
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as VideoCreatedDomainEvent;
            if (item == null) return false;

            return
                string.Equals(AggregateId, item.AggregateId, StringComparison.InvariantCulture) &&
                int.Equals(TypeId, item.TypeId) &&
                string.Equals(Title, item.Title, StringComparison.InvariantCulture) &&
                string.Equals(Url, item.Url, StringComparison.InvariantCulture) &&
                string.Equals(CourseId, item.CourseId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AggregateId, TypeId, Title, Url, CourseId);
        }
    }
}

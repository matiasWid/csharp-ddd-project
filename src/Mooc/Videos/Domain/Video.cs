using System;
using System.Collections.Generic;
using System.Text;
using CodelyTv.Mooc.Shared.Domain;
using CodelyTv.Shared.Domain.Aggregate;
using CodelyTv.Shared.Domain.Videos.Domain;

namespace CodelyTv.Mooc.Videos.Domain
{
    public class Video : AggregateRoot
    {
        public VideoId Id { get;}
        public VideoType Type { get;}
        public VideoTitle Title { get;}
        public VideoUrl Url { get;}
        public CourseId CourseId { get;}
        private Video()
        {
        }
        public Video(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            Id = id;
            Type = type;
            Title = title;
            Url = url;
            CourseId = courseId;
        }

        public static Video Create(VideoId id, VideoType type, VideoTitle title, VideoUrl url, CourseId courseId)
        {
            var video = new Video(id, type, title, url, courseId);

            video.Record(
                new VideoCreatedDomainEvent(id.Value, type.Id, title.Value,
                url.Value, courseId.Value));

            return video;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as Video;
            if (item == null) return false;

            return Id.Equals(item.Id) &&
                Type.Equals(item.Type) &&
                Url.Equals(item.Url) &&
                CourseId.Equals(item.CourseId);                
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Type, Url, CourseId);
        }
    }
}

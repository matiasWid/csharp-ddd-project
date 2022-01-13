using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Shared.Domain.Bus.Command;

namespace CodelyTv.Mooc.Videos.Application.Create
{
    public class CreateVideoCommand : Command
    {
        public string Id { get; }
        public string Type { get; }
        public string Title { get; }
        public string Url { get; }
        public string CourseId { get; }

        public CreateVideoCommand(string id, string type, string title, string url, string courseId)
        {
            Id = id;
            Type = type;
            Title = title;
            Url = url;
            CourseId = courseId;
        }
    }
}

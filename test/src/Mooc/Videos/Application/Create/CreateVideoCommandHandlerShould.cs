using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Videos.Application.Create;
using CodelyTv.Test.Mooc.Videos.Domain;
using Xunit;

namespace CodelyTv.Test.Mooc.Videos.Application.Create
{
    public class CreateVideoCommandHandlerShould : VideosModuleUnitTestCase
    {
        private readonly CreateVideoCommandHandler _handler;

        public CreateVideoCommandHandlerShould()
        {
            _handler = new CreateVideoCommandHandler(new VideoCreator(Repository.Object, EventBus.Object));

        }

        [Fact]
        public void create_a_valid_video()
        {
            var command = CreateVideoCommandMother.Random();
            var video = VideoMother.FromRequest(command);
            var domainEvent = VideoPublishedDomainEventMother.FromVideo(video);

            _handler.Handle(command);

            ShouldHaveSave(video);
            ShouldHavePublished(domainEvent);
        }
    }
}

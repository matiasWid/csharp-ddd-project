using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Videos.Application.Create;

namespace CodelyTv.Test.Mooc.Videos.Application
{
    public class CreateVideoCommandHandlerShould : VideosModuleUnitTestCase
    {
        private readonly CreateVIdeoCommandHandler _handler;

        public CreateVideoCommandHandlerShould()
        {
            _handler = new CreateVIdeoCommandHandler(new VideoCreator(Repository.Object, EventBus.Object));

        }

        [Fact]
        public void create_a_valid_video()
        {
            var command = Crea
        }
    }
}

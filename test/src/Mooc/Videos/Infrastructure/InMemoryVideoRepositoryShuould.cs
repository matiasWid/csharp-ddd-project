using System.Threading.Tasks;
using CodelyTv.Test.Mooc.Videos.Domain;
using Newtonsoft.Json;
using Xunit;

namespace CodelyTv.Test.Mooc.Videos.Infrastructure
{
    public class InMemoryVideoRepositoryShuould : VideosModuleInfrastructureTestCase
    {
        [Fact]
        public async Task save_a_video()
        {
            var video = VideoMother.Random();
            await Repository.Save(video);
        }

        [Fact]
        public async Task return_an_existing_video()
        {
            var video = VideoMother.Random();

            await Repository.Save(video);

            Assert.Equal(JsonConvert.SerializeObject(video),
                JsonConvert.SerializeObject(await Repository.Search(video.Id)));
        }

        [Fact]
        public async Task not_return_a_non_existing_video()
        {
            Assert.Null(await Repository.Search(VideoIdMother.Random()));
        }
    }
}

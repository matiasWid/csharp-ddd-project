using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Test.Shared.Infrastructure;
using Moq;

namespace CodelyTv.Test.Mooc.Videos
{
    public class VideosModuleUnitTestCase : UnitTestCase
    {
        protected readonly Mock<VideoRepository> Repository;

        public VideosModuleUnitTestCase()
        {
            Repository = new Mock<VideoRepository>();
        }

        protected void ShouldHaveSave(Video video)
        {
            Repository.Verify(x => x.Save(video), Times.AtLeastOnce());
        }
    }
}

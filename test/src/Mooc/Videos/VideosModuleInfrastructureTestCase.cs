using CodelyTv.Mooc.Videos.Domain;

namespace CodelyTv.Test.Mooc.Videos
{
    public abstract class VideosModuleInfrastructureTestCase : MoocContextInfrastructureTestCase
    {
        protected VideoRepository Repository => GetService<VideoRepository>();
    }
}

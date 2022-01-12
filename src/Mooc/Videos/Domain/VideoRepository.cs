using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Shared.Domain.FiltersByCriteria;

namespace CodelyTv.Mooc.Videos.Domain
{
    public interface VideoRepository
    {
        Task Save(Video video);
        Task<Video> Search(VideoId id);
        Task<IEnumerable<Video>> Matching(Criteria criteria);
    }
}

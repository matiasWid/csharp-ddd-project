using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Infrastructure.Persistence.EntityFramework;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.FiltersByCriteria;
using Microsoft.EntityFrameworkCore;

namespace CodelyTv.Mooc.Videos.Infrastructure.Persistence
{
    public class MsSqlVideoRepository : VideoRepository
    {
        private readonly MoocContext _context;

        public MsSqlVideoRepository(MoocContext context)
        {
            this._context = context;
        }
        public Task<IEnumerable<Video>> Matching(Criteria criteria)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Video video)
        {
            await _context.Videos.AddAsync(video);
            await _context.SaveChangesAsync();
        }

        public async Task<Video> Search(VideoId id)
        {
            return await _context.Videos.FirstOrDefaultAsync(v => v.Id.Equals(id));
        }
    }
}

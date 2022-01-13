using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Domain.FiltersByCriteria;
using Newtonsoft.Json;

namespace CodelyTv.Mooc.Videos.Infrastructure
{
    public class FileVideoRepository : VideoRepository
    {
        private readonly string _filePath = Directory.GetCurrentDirectory() + "/videos";

        public async Task Save(Video video)
        {
            await Task.Run(() =>
            {
                using (var outputFile = new StreamWriter(FileName(video.Id.Value), false))
                {
                    outputFile.WriteLine(JsonConvert.SerializeObject(video));
                }
            });
            throw new NotImplementedException();
        }

        public async Task<Video> Search(VideoId id)
        {
            if (File.Exists(FileName(id.Value)))
            {
                var text = await File.ReadAllTextAsync(FileName(id.Value));
                return JsonConvert.DeserializeObject<Video>(text);
            }

            return null;
        }

        public Task<IEnumerable<Video>> Matching(Criteria criteria)
        {
            throw new NotImplementedException();
        }

        private string FileName(string id)
        {
            return $"{_filePath}.{id}.repo";
        }

    }
}

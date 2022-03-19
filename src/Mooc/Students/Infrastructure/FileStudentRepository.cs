
using System.IO;
using System.Threading.Tasks;
using CodelyTv.Mooc.Students.Domain;
using Newtonsoft.Json;

namespace CodelyTv.Mooc.Students.Infrastructure
{
    public class FileStudentRepository : StudentRepository
    {
        private readonly string _filePath = Directory.GetCurrentDirectory() + "/students";
        public async Task Save(Student student)
        {
            await Task.Run(() =>
            {
                using (var outputFile = new StreamWriter(FileName(student.Id.Value), false))
                {
                    outputFile.WriteLine(JsonConvert.SerializeObject(student));
                }
            });
        }

        public async Task<Student> Search(StudentId id)
        {
            if (File.Exists(FileName(id.Value)))
            {
                var text = await File.ReadAllTextAsync(FileName(id.Value));
                return JsonConvert.DeserializeObject<Student>(text);
            }

            return null;
        }

        private string FileName(string id)
        {
            return $"{_filePath}.{id}.repo";
        }
    }
}

using System.Threading.Tasks;
using CodelyTv.Test.Mooc.Students.Domain;
using Newtonsoft.Json;
using Xunit;

namespace CodelyTv.Test.Mooc.Students.Infrastructure.Persistence
{
    public class MsSqlStudentRepositoryShould : StudentsModuleInfrastructureTestCase
    {
        [Fact]
        public async Task save_a_student()
        {
            var student = StudentMother.Random();
            await Repository.Save(student);
        }

        [Fact]
        public async Task return_an_existing_student()
        {
            var student = StudentMother.Random();

            await Repository.Save(student);

            Assert.Equal(JsonConvert.SerializeObject(student),
                JsonConvert.SerializeObject(await Repository.Search(student.Id)));
        }

        [Fact]
        public async Task not_return_a_non_existing_student()
        {
            Assert.Null(await Repository.Search(StudentIdMother.Random()));
        }
    }
}

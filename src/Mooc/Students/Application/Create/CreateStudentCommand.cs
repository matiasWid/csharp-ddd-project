using CodelyTv.Shared.Domain.Bus.Command;

namespace CodelyTv.Mooc.Students.Application.Create
{
    public class CreateStudentCommand : Command
    {
        public string Id { get; }
        public string Name { get; }

        public CreateStudentCommand(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

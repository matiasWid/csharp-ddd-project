using CodelyTv.Mooc.Students.Domain;

namespace CodelyTv.Test.Mooc.Students
{
    public abstract class StudentsModuleInfrastructureTestCase : MoocContextInfrastructureTestCase
    {
        protected StudentRepository Repository => GetService<StudentRepository>();
    }
}

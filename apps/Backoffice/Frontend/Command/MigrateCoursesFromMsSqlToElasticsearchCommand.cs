using System.Collections.Generic;
using CodelyTv.Backoffice.Courses.Domain;
using CodelyTv.Backoffice.Courses.Infrastructure.Persistence;
using CodelyTv.Backoffice.Courses.Infrastructure.Persistence.Elasticsearch;
using CodelyTv.Mooc.Courses.Domain;

namespace CodelyTv.Apps.Backoffice.Frontend.Command
{
    public class MigrateCoursesFromMsSqlToElasticsearchCommand : Shared.Cli.Command
    {
        private readonly MsSqlBackofficeCourseRepository msSqlBackofficeCourseRepository;
        private readonly ElasticsearchBackofficeCourseRepository elasticsearchBackofficeCourseRepository;

        public MigrateCoursesFromMsSqlToElasticsearchCommand(MsSqlBackofficeCourseRepository msSqlBackofficeCourseRepository,
            ElasticsearchBackofficeCourseRepository elasticsearchBackofficeCourseRepository)
        {
            this.msSqlBackofficeCourseRepository = msSqlBackofficeCourseRepository;
            this.elasticsearchBackofficeCourseRepository = elasticsearchBackofficeCourseRepository;
        }

        public override void Execute(string[] args)
        {
            var courses = msSqlBackofficeCourseRepository.SearchAll().Result;
            foreach(var course in courses)
            {
                elasticsearchBackofficeCourseRepository.Save(course).Wait();
            }
        }
    }
}

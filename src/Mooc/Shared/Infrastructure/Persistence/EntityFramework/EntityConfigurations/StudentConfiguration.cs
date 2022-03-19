using CodelyTv.Mooc.Students.Domain;
using CodelyTv.Shared.Infrastructure.Persistence.EntityFramework.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodelyTv.Mooc.Shared.Infrastructure.Persistence.EntityFramework.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(MoocContext.Students).ToDatabaseFormat());

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(v => v.Value, v => new StudentId(v))
                .HasColumnName(nameof(Student.Id).ToDatabaseFormat());

            builder.Property(x => x.Name)
                .HasConversion(v => v.Value, v => new StudentName(v))
                .HasColumnName(nameof(Student.Name).ToDatabaseFormat());
        }
    }
}

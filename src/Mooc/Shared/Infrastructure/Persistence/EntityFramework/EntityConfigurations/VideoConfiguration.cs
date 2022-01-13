using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodelyTv.Mooc.Videos.Domain;
using CodelyTv.Shared.Infrastructure.Persistence.EntityFramework.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodelyTv.Mooc.Shared.Infrastructure.Persistence.EntityFramework.EntityConfigurations
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable(nameof(MoocContext.Videos).ToDatabaseFormat());

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(v => v.Value, v => new VideoId(v))
                .HasColumnName(nameof(Video.Id).ToDatabaseFormat());

            builder.OwnsOne(x => x.Title)
                .Property(x => x.Value)
                .HasColumnName(nameof(Video.Title).ToDatabaseFormat());

            builder.OwnsOne(x => x.Type)
                .Property(x => x.Value)
                .HasColumnName(nameof(Video.Type).ToDatabaseFormat());

            builder.OwnsOne(x => x.Url)
                .Property(x => x.Value)
                .HasColumnName(nameof(Video.Type).ToDatabaseFormat());

            builder.Property(x => x.CourseId)
                .HasConversion(v => v.Value, v => new Domain.CourseId(v))
                .HasColumnName(nameof(Video.CourseId).ToDatabaseFormat());
        }
    }
}

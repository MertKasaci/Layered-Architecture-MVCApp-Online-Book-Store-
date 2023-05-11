using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(50);
            builder.Property(p => p.Body).HasMaxLength(250);
            builder.Property(p => p.NumberOfLikes).HasDefaultValue(0);
            builder.Property(p => p.NumberOfDislikes).HasDefaultValue(0);
        }
    }
}

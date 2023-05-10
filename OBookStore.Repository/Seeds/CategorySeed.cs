using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category() { Id = 1, Title = "Literature", CreatedDate = DateTime.Now },
                new Category() { Id = 2, Title = "History", CreatedDate = DateTime.Now },
                new Category() { Id = 3, Title = "Philosophy", CreatedDate = DateTime.Now },
                new Category() { Id = 4, Title = "Science", CreatedDate = DateTime.Now },
                new Category() { Id = 5, Title = "Engineering", CreatedDate = DateTime.Now },
                new Category() { Id = 6, Title = "Software", CreatedDate = DateTime.Now },
                new Category() { Id = 7, Title = "Kids", CreatedDate = DateTime.Now },
                new Category() { Id = 8, Title = "Economy", CreatedDate = DateTime.Now },
                new Category() { Id = 9, Title = "Sociology", CreatedDate = DateTime.Now },
                new Category() { Id = 10, Title = "Art", CreatedDate = DateTime.Now }

           );
        }
    }
}

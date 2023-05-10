using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OBookStore.Core.DataGenerator;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
     {
        private readonly IDataGenerator _generator;
        public BookSeed(IDataGenerator generator)
        {
            _generator = generator;
            
        }


        public void Configure(EntityTypeBuilder<Book> builder)
        {
            IEnumerable<Book> enumBooks = _generator.bookDataGenerator();
            builder.HasData(enumBooks);

        
        }
    }
}

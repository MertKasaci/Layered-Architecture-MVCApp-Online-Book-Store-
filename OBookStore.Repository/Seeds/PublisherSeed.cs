using Bogus;
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
    public class PublisherSeed : IEntityTypeConfiguration<Publisher>
    {
        private readonly IDataGenerator _generator;
        public PublisherSeed(IDataGenerator generator)
        {
            _generator = generator;
            
        }
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            

             
            builder.HasData(_generator.publisherDataGenerator());
        }
    }
}

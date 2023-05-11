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
        //private readonly IDataGenerator _generator;
        //public PublisherSeed(IDataGenerator generator)
        //{
        //    _generator = generator;
            
        //}
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {



            //builder.HasData(_generator.publisherDataGenerator());
            builder.HasData(
                 
                  new Publisher() { Id = 1, Name="Tubitak Publishing", Description = "Tubitak publishes books about scientific things",AddressDescription = "Istanbul/Turkey", Email =  "tubitak@hotmail.com.tr" },
                  new Publisher() { Id = 2, Name = "Yapi Kredi Publishing", Description = "Yapı Kredi publishes books about different topics", AddressDescription = "Ankara/Turkey", Email = "tubitak@hotmail.com.tr" }, 
                  new Publisher() { Id = 3, Name = "Karbon Publishing", Description = "Karbon publishes books about different topics", AddressDescription = "Izmir/Turkey", Email = "karbon@hotmail.com.tr" },
                  new Publisher() { Id = 4, Name = "Kronik Publishing", Description = "Kronik publishes books about different topics", AddressDescription = "Bursa/Turkey", Email = "kronik@hotmail.com.tr" },
                  new Publisher() { Id = 5, Name = "Ithaki Publishing", Description = "Ithaki publishes books about different topics", AddressDescription = "Ankara/Turkey", Email = "ithaki@hotmail.com.tr" },
                  new Publisher() { Id = 6, Name = "Everest Publishing", Description = "Everest publishes books about different topics", AddressDescription = "Ankara/Turkey", Email = "everest@hotmail.com.tr" },
                  new Publisher() { Id = 7, Name = "Remzi Publishing", Description = "Remzi publishes books about different topics", AddressDescription = "Izmir/Turkey", Email = "remzi@hotmail.com.tr" },
                  new Publisher() { Id = 8, Name = "Epsilon Publishing", Description = "Epsilon publishes books about different topics", AddressDescription = "Istanbul/Turkey", Email = "epsilon@hotmail.com.tr" },
                  new Publisher() { Id = 9, Name = "Can Publishing", Description = "Can publishes books about different topics", AddressDescription = "Istanbul/Turkey", Email = "can@hotmail.com.tr" },
                  new Publisher() { Id = 10, Name = "Altin Publishing", Description = "Altin publishes books about different topics", AddressDescription = "Istanbul/Turkey", Email = "altin@hotmail.com.tr" },
                  new Publisher() { Id = 11, Name = "Alfa Publishing", Description = "Alfa publishes books about different topics", AddressDescription = "Izmir/Turkey", Email = "alfa@hotmail.com.tr" },
                  new Publisher() { Id = 12, Name = "Panama Publishing", Description = "Panama publishes books about different topics", AddressDescription = "Ankara/Turkey", Email = "panama@hotmail.com.tr" }




                );

        }
    }
}

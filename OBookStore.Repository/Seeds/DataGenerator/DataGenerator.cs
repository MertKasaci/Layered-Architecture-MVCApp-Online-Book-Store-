using Bogus;
using OBookStore.Core.DataGenerator;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Seeds.DataGenerator
{
    public class DataGenerator : IDataGenerator
    {

        public List<Book> bookDataGenerator()
        {
            int id = 1;

            var bookDataGenerator = new Faker<Book>()
                .RuleFor(b => b.Id, d => id++)
                .RuleFor(b => b.Title, d => d.Lorem.Word())
                .RuleFor(b => b.Description, d => d.Lorem.Text())
                .RuleFor(b => b.NumberOfLikes, d => d.Random.Int(1, 100))
                .RuleFor(b => b.NumberOfDislikes, d => d.Random.Int(1, 100))
                .RuleFor(b => b.NumberOfEdition, d => d.Random.Int(1, 20))
                .RuleFor(b => b.NumberOfPages, d => d.Random.Int(250, 1000))
                .RuleFor(b => b.NumberOfSolds, d => d.Random.Int(1, 100))
                .RuleFor(b => b.NumberOfStocks, d => d.Random.Int(10, 50))
                .RuleFor(b => b.Price, d => d.Commerce.Price(1).First())
                .RuleFor(b => b.CategoryId, d => d.Random.Int(1, 10))
                .RuleFor(b => b.PublisherId, d => d.Random.Int(1, 10));

            return bookDataGenerator.GenerateBetween(20, 20);

        }

        public List<Publisher> publisherDataGenerator()
        {
            int id = 1;
            var publisherDataGenerator = new Faker<Publisher>()
                .RuleFor(p => p.Id, d => id++)
                .RuleFor(p => p.Name, d => d.Company.CompanyName())
                .RuleFor(p => p.Description, d => d.Lorem.Text())
                .RuleFor(p => p.AddressDescription, d => d.Address.FullAddress())
                .RuleFor(p => p.Email, d => d.Internet.Email());

            return publisherDataGenerator.GenerateBetween(20, 20);
        }

    }
}

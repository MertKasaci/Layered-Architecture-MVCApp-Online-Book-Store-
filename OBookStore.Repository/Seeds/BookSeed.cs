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
        //private readonly IDataGenerator _generator;
        //public BookSeed(IDataGenerator generator)
        //{
        //    _generator = generator;
            
        //}


        public void Configure(EntityTypeBuilder<Book> builder)
        {
            

            
            //builder.HasData(_generator.bookDataGenerator());
            builder.HasData(
                
             new Book() { Id=1 , Title = "In Search Of Lost Time" , Description= "Swann's Way, the first part of A la recherche de temps perdu, Marcel Proust's seven-part cycle, was published in 1913",NumberOfPages=425,NumberOfEdition=10,NumberOfStocks=10,NumberOfSolds=25 , NumberOfDislikes=100,NumberOfLikes=50,Price=60,CategoryId=5,PublisherId=2},
             new Book() { Id = 2, Title = "Ulysses", Description = "Ulysses chronicles the passage of Leopold Bloom through Dublin during an ordinary day, June 16, 1904", NumberOfPages = 725, NumberOfEdition = 25, NumberOfStocks = 20, NumberOfSolds = 55, NumberOfDislikes = 10, NumberOfLikes = 150, Price = 100, CategoryId = 2, PublisherId = 7 },
             new Book() { Id = 3, Title = "Don Quiote", Description = "Alonso Quixano, a retired country gentleman in his fifties", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 10, NumberOfSolds = 40, NumberOfDislikes = 100, NumberOfLikes = 75, Price = 60, CategoryId = 5, PublisherId = 5 },
             new Book() { Id = 4, Title = "Moby Dick", Description = "First published in 1851, Melville's masterpiece is, in Elizabeth Hardwick's words", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 10, NumberOfSolds = 30, NumberOfDislikes = 100, NumberOfLikes = 20, Price = 60, CategoryId = 5, PublisherId = 1 },
             new Book() { Id = 5, Title = "War And Peace", Description = "War and Peace delineates in graphic detail events leading up to Napoleon's invasion of Russia", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 0 , NumberOfSolds = 60, NumberOfDislikes = 100, NumberOfLikes = 90, Price = 60, CategoryId = 5, PublisherId = 10 },
             new Book() { Id = 6, Title = "Hamlet", Description = "The Tragedy of Hamlet, Prince of Denmark, or more simply Hamlet", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 10, NumberOfSolds = 50, NumberOfDislikes = 100, NumberOfLikes = 80, Price = 60, CategoryId = 5, PublisherId = 11 },
             new Book() { Id = 7, Title = "The Odyssey", Description = "The Odyssey is one of two major ancient Greek epic poems attributed to Homer", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 10, NumberOfSolds = 100, NumberOfDislikes = 100, NumberOfLikes = 150, Price = 60, CategoryId = 5, PublisherId = 6 },
             new Book() { Id = 8, Title = "The Brothers Karamazow", Description = "Dostoevsky's last and greatest novel, The Karamazov Brothers", NumberOfPages = 425, NumberOfEdition = 10, NumberOfStocks = 10, NumberOfSolds = 10, NumberOfDislikes = 100, NumberOfLikes = 30, Price = 60, CategoryId = 5, PublisherId = 5}
             );

        
        }
    }
}

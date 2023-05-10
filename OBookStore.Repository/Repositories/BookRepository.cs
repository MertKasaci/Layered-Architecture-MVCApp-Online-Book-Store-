using OBookStore.Core.Entities;
using OBookStore.Core.Repositories;
using OBookStore.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookStoreAppDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Book> GetRecentlyAddedBooks()
        {
             return _dbContext.Books.OrderByDescending(book => book.CreatedDate).Take(12);
        }

        public IQueryable<Book> GetTopBoughtBooks()
        {
            return _dbContext.Books.OrderByDescending(book => book.NumberOfSolds).Take(12);
        }

        public IQueryable<Book> GetTopLikedBooks()
        {
            return _dbContext.Books.OrderByDescending(book => book.NumberOfLikes).Take(12);
        }
    }
}

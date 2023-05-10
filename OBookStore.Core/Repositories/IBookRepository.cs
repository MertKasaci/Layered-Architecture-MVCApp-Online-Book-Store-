using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Repositories
{
    public interface IBookRepository : IGenericRepository<Book> 
    {
        IQueryable<Book> GetRecentlyAddedBooks();
        IQueryable<Book> GetTopLikedBooks();
        IQueryable<Book> GetTopBoughtBooks();
        

        

    }
}

using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Core.Services
{
    public interface IBookService : IGenericService<Book>
    {
        Task<List<Book>> GetRecentlyAddedBooksAsync();
        Task<List<Book>> GetTopBoughtBooksAsync();
        Task<List<Book>> GetTopLikedBooksAsync();

    }
}

using Microsoft.EntityFrameworkCore;
using OBookStore.Core.Entities;
using OBookStore.Core.Repositories;
using OBookStore.Core.Services;
using OBookStore.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Services
{
    public class BookService : GenericService<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IUnitOfWork unitOfWork, IGenericRepository<Book> repository, IBookRepository bookRepository) : base(unitOfWork, repository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> GetRecentlyAddedBooksAsync()
        {
            return await _bookRepository.GetRecentlyAddedBooks().ToListAsync();
        }

        public async Task<List<Book>> GetTopBoughtBooksAsync()
        {
            return  await _bookRepository.GetTopBoughtBooks().ToListAsync();
        }

        public async Task<List<Book>> GetTopLikedBooksAsync()
        {
            return await _bookRepository.GetTopLikedBooks().ToListAsync();
        }

       
    }
}

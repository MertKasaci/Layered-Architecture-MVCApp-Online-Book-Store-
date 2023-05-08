using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OBookStore.Core.Entities;
using OBookStore.Core.Services;

namespace OBookStore.WebMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IGenericService<Book> _genericService;
        private readonly IMapper _mapper;

        public BookController(IGenericService<Book> genericService , IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

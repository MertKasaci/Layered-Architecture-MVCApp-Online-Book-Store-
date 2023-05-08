using AutoMapper;
using OBookStore.Core.DTOs;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Author,AuthorDto>().ReverseMap();
            CreateMap<BookAddingDto, Book>();
            CreateMap<Book, BookDetailsDto>();
            CreateMap<Book, BookUpdatingDto>();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CommentAddingDto, Comment>();
            CreateMap<Comment, CommentDetailsDto>();
            CreateMap<CommentUpdateDto, Comment>();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Publisher, PublisherDto>().ReverseMap();
            CreateMap<User, UserDetailsDto>();
            CreateMap<UserSignInDto, User>();
            CreateMap<UserSignUpDto, User>();
            CreateMap<UserUpdateDto, User>();
            

            
        }



    }
}

using FluentValidation;
using OBookStore.Core.DTOs;
using OBookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public  class BookUpdatingDtoValidator : AbstractValidator<BookUpdatingDto>
    {
        public BookUpdatingDtoValidator()
        {
            RuleFor(book => book.Description).NotEmpty().NotNull().MaximumLength(250);
            RuleFor(book => book.NumberOfPages).GreaterThanOrEqualTo(250);
            RuleFor(book => book.NumberOfEdition).GreaterThan(0);
            RuleFor(book => book.Price).GreaterThan(0);
         }


    }
}

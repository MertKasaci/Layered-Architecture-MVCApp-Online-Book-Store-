using FluentValidation;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class BookAddingDtoValidator : AbstractValidator<BookAddingDto>
    {

        public BookAddingDtoValidator()
        {
            RuleFor(book => book.Title).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(book => book.Description).NotEmpty().NotNull().MaximumLength(250);
            RuleFor(book => book.NumberOfPages).GreaterThanOrEqualTo(250);
            RuleFor(book => book.NumberOfEdition).GreaterThan(0);
            RuleFor(book => book.Price).GreaterThan(0);

            
        }
    }
}

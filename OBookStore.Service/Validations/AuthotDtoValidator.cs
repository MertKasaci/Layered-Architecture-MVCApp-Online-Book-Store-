using FluentValidation;
using FluentValidation.AspNetCore;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class AuthotDtoValidator : AbstractValidator<AuthorDto>
    {
        public AuthotDtoValidator()
        {
            RuleFor(author => author.FirstName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(author => author.LastName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(author => author.Description).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(author => author.Age).NotNull().NotEmpty().GreaterThan(18);
            RuleFor(author => author.Email).EmailAddress().NotEmpty().NotNull();
            
        }

    }
}

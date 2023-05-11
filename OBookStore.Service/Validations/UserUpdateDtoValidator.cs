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
    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateDtoValidator()
        {
            RuleFor(user => user.FirstName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(user => user.LastName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(user => user.PhoneNumber).NotNull().NotEmpty().MaximumLength(10);
            RuleFor(user => user.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(user => user.AddressDescription).NotNull().NotEmpty();
            RuleFor(user => user.UserName).NotNull().NotEmpty().MaximumLength(25);
            RuleFor(user => user.Password).NotNull().NotEmpty().MaximumLength(10);

        }
        


    }
}

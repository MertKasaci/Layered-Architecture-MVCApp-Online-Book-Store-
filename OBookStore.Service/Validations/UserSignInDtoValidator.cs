using FluentValidation;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class UserSignInDtoValidator : AbstractValidator<UserSignInDto>
    {
        public UserSignInDtoValidator()
        {
            RuleFor(user => user.UserName).NotNull().NotEmpty();
            RuleFor(user => user.Password).NotNull().NotEmpty();

            
        }

    }
}

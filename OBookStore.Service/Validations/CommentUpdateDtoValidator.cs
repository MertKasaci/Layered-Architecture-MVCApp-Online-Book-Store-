using FluentValidation;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class CommentUpdateDtoValidator : AbstractValidator<CommentUpdateDto>
    {

        public CommentUpdateDtoValidator()
        {
            RuleFor(comment => comment.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(comment => comment.Body).NotEmpty().NotNull().MaximumLength(150);
        }


    }
}

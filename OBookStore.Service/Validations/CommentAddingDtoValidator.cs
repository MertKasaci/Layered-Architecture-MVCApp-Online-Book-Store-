using FluentValidation;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class CommentAddingDtoValidator : AbstractValidator<CommentAddingDto>
    {
        public CommentAddingDtoValidator()
        {
            RuleFor(comment => comment.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(comment => comment.Body).NotNull().NotEmpty().MaximumLength(150);
            
        }


    }
}

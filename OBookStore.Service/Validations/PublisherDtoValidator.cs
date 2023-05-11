using FluentValidation;
using OBookStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBookStore.Service.Validations
{
    public class PublisherDtoValidator : AbstractValidator<PublisherDto>
    {

        public PublisherDtoValidator()
        {
            RuleFor(publisher => publisher.Name).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(publisher => publisher.Description).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(publisher => publisher.AddressDescription).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(publisher => publisher.Email).NotNull().NotEmpty().EmailAddress();
            
        }
    }
}

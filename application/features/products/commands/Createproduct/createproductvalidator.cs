using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.features.products.commands.Createproduct
{
    public class CreateproductValidator : AbstractValidator<CreateproductCommand>
    {
        public CreateproductValidator()
        {
            RuleFor(a => a.Name)
               .NotEmpty().WithMessage(a => "Name is empty.")
               .NotNull().WithMessage(a => "Name is required.")
              
               .MaximumLength(200).WithMessage(a => "name must not exceed 200 characters.");
        }
    }
}

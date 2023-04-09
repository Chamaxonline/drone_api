using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels.Validator
{
   public  class MedicationValidator: AbstractValidator<MedicationViewModel>
    {
        public MedicationValidator()
        {
            RuleFor(x => x.Name)
                        .Matches("^[a-zA-Z0-9]*$")
                        .WithMessage("Name must contain only letters and numbers.");
            RuleFor(x => x.Code)
                        .Matches("^[A-Z0-9_]*$")
                        .WithMessage("Code only allowed upper case letters, underscore and numbers);");
        }
    }
}

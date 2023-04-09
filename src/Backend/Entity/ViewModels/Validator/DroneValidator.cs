using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels.Validator
{
    public class DroneValidator : AbstractValidator<DroneViewModel>
    {
        public DroneValidator()
        {
            RuleFor(model => model.SerialNumber).MaximumLength(100).WithMessage("Character limit must be less than 100);");
            RuleFor(model => model.WeightLimit).LessThanOrEqualTo(500).WithMessage("Maximum Weight Limit must be 500gr" );




        }
    }
}

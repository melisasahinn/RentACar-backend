using Business.Constant;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).GreaterThan(0).WithMessage(Messages.CarDailyPriceInvalid);
            //RuleFor(p => p.Name).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("a");
        }
    }
}
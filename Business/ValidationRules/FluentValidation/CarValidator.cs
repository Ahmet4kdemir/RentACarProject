using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //kurallar business yerine buraya
            RuleFor(c => c.ModelName).NotEmpty();
            RuleFor(c => c.ModelName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //  RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.CarId == 1);
            //  RuleFor(c=>c.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); // must ın içine fonksiyon koyabilirz.



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

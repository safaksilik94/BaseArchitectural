using FluentValidation;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2,30);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryID == 1);
            RuleFor(p => p.ProductName).Must(StartWithWithA);
        }

        private bool StartWithWithA(string arg)
        {
            return arg.StartsWith("s");
        }
    }
}

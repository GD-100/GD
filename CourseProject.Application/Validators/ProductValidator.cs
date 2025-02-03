using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Domain.Models;
using FluentValidation;

namespace CourseProject.Application.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Името на продукта е задължително.")
                .MaximumLength(100).WithMessage("Името не може да е по-дълго от 100 символа.");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Цената трябва да е положителна.");

            RuleFor(p => p.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Наличността не може да е отрицателна.");
        }
    }
}

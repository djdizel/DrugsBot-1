﻿using FluentValidation;
using Domain.Entities;
using Domain.Primitives;

namespace Domain.Validators
{
    public class CountryValidator : AbstractValidator<Country>
    {
        public CountryValidator()
        {
            // Валидация для имени
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage(ValidationMessage.RequiredField)
                .Length(2, 100).WithMessage(ValidationMessage.LengthField)
                .Matches(@"^[A-Za-z\s]+$").WithMessage(ValidationMessage.OnlyLettersAndSpaces);
            
            // Валидация для кода
            RuleFor(c => c.Code)
                .NotEmpty().WithMessage(ValidationMessage.RequiredField)
                .Length(2).WithMessage(ValidationMessage.ExactLengthField)
                .Matches(@"^[A-Z]{2}$").WithMessage(ValidationMessage.OnlyUppercaseLetters);
        }
    }
}
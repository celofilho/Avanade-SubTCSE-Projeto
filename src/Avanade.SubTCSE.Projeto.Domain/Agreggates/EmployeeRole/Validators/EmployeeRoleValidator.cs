﻿using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not empty");
            });

            RuleSet("GetById" , () =>
            {
                RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} não pode ser nulo, amigão");

            });
        }
    }
}

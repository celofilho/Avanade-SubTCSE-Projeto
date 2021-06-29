using Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.Employee.Validators
{
    public class EmployeeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not empty");

                RuleFor(e => e.SurName)
               .NotEmpty()
               .WithMessage("{PropertyName} can not empty");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValidator());
            });
        }
    }
}

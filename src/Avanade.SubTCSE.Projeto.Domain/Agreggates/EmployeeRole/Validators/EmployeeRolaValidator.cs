using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Agreggates.EmployeeRole.Validators
{
    public class EmployeeRolaValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRolaValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not empty");
            });
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Domain.Aggregates.EmployeeRole.Validators
{
    class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");
            });
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL;
public sealed class RemoveByIdMainRoleAndUserRLCommandValidator : AbstractValidator<RemoveByIdMainRoleAndUserRLCommand>
{
    public RemoveByIdMainRoleAndUserRLCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
    }
}
using Application.Messaging;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

public sealed class UpdateMainRoleCommandValidator : AbstractValidator<UpdateMainRoleCommand>
{
    public UpdateMainRoleCommandValidator()
    {
        RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
        RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        RuleFor(p => p.Title).NotEmpty().WithMessage("Başlık alanı boş olamaz!");
        RuleFor(p => p.Title).NotNull().WithMessage("Başlık alanı boş olamaz!");
    }
}

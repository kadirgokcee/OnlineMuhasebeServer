using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL;
public sealed class CreateUserAndCompanyRLCommandValidator : AbstractValidator<CreateUserAndCompanyRLCommand>
{
    public CreateUserAndCompanyRLCommandValidator()
    {
        RuleFor(p => p.AppUserId).NotEmpty().WithMessage("Kullanıcı seçilmelidir!");
        RuleFor(p => p.AppUserId).NotNull().WithMessage("Kullanıcı seçilmelidir!");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçilmelidir!");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçilmelidir!");
    }
}
using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.AuthFeatures.Commands
{
    public sealed record LoginCommandResponse(
        TokenRefreshTokenDto Token,
        string Email,
        string UserId,
        string NameLastName,
        IList<CompanyDto> Companies,
        CompanyDto Company);
}
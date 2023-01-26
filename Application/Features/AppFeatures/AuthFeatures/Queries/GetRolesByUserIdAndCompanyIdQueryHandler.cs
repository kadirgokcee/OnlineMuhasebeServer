using Application.Messaging;
using Application.Services.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.AuthFeatures.Queries;
public sealed class GetRolesByUserIdAndCompanyIdQueryHandler : IQueryHander<GetRolesByUserIdAndCompanyIdQuery, GetRolesByUserIdAndCompanyIdQueryResponse>
{
    private readonly IAuthService _authService;

    public GetRolesByUserIdAndCompanyIdQueryHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<GetRolesByUserIdAndCompanyIdQueryResponse> Handle(GetRolesByUserIdAndCompanyIdQuery request, CancellationToken cancellationToken)
    {
        IList<string> roles = await _authService.GetRolesByUserIdAndCompanyId(request.UserId, request.CompanyId);

        return new(roles);
    }
}
using Application.Messaging;
using Application.Services.AppServices;
using Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.RoleFeatures.Queries;

public sealed class GetAllRolesQueryHandler : IQueryHander<GetAllRolesQuery, GetAllRolesQueryResponse>
{
    private readonly IRoleService _roleService;

    public GetAllRolesQueryHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<GetAllRolesQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        IList<AppRole> roles = await _roleService.GetAllRolesAsync();
        return new(roles);
    }
}
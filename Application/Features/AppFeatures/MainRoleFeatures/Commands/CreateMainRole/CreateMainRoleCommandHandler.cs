using Application.Messaging;
using Application.Services.AppServices;
using Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed class CreateMainRoleCommandHandler : ICommandHandler<CreateMainRoleCommand, CreateMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateMainRoleCommandResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.CompanyId, cancellationToken);
        if (checkMainRoleTitle != null) throw new Exception("Bu rol daha önce kaydedilmiş!");

        MainRole mainRole = new(
            Guid.NewGuid().ToString(),
            request.Title,
            request.CompanyId != null ? false : true,
            request.CompanyId);

        await _mainRoleService.CreateAsync(mainRole, cancellationToken);

        return new();
    }
}
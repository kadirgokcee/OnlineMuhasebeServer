using Application.Messaging;
using Application.Services.AppServices;
using Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
public sealed class RemoveByIdMainRoleAndRoleRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand, RemoveByIdMainRoleAndRoleRLCommandResponse>
{
    private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

    public RemoveByIdMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
    {
        _roleRelationshipService = roleRelationshipService;
    }

    public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
    {
        MainRoleAndRoleRelationship entity = await _roleRelationshipService.GetByIdAsync(request.Id);
        if (entity == null) throw new Exception("Belirtilen Ana Rol ve Rol bağlantısı bulunamadı!");

        await _roleRelationshipService.RemoveByIdAsync(request.Id);
        return new();
    }
}
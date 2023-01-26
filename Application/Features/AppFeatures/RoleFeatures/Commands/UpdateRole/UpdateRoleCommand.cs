using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;


    public sealed record UpdateRoleCommand(
        string Id,
        string Code,
        string Name) : ICommand<UpdateRoleCommandResponse>;

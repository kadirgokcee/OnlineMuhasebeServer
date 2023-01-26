using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole
{
    public sealed record RemoveByIdMainRoleCommand(
        string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;
}
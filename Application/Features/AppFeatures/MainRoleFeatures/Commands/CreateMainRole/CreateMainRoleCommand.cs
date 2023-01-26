using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed record CreateMainRoleCommand(
    string Title,
    string CompanyId = null) : ICommand<CreateMainRoleCommandResponse>;
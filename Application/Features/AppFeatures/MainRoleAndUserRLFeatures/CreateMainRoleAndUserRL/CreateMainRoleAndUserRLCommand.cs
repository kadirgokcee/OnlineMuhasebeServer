using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndUserRLFeatures.CreateMainRoleAndUserRL;
public sealed record CreateMainRoleAndUserRLCommand(
    string UserId,
    string MainRoleId,
    string CompanyId) : ICommand<CreateMainRoleAndUserRLCommandResponse>;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
public sealed record RemoveByIdMainRoleAndRoleRLCommandResponse(
    string Message = "Role ve Ana Rol bağlantısı koparıldı");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndUserRLFeatures.CreateMainRoleAndUserRL;

public sealed record CreateMainRoleAndUserRLCommandResponse(
    string Message = "Kullanıcıya rol ataması başarılı!");
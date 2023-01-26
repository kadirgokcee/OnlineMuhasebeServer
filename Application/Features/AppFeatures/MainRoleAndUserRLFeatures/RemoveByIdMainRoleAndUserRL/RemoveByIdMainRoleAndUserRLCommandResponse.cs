using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL;


public sealed record RemoveByIdMainRoleAndUserRLCommandResponse(
    string Message = "Kullanıcıdan rol yetkisi kaldırıldı");
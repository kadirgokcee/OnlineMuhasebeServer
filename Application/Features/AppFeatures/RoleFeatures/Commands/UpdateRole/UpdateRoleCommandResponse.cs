using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;


    public sealed record UpdateRoleCommandResponse(
        string Message = "Role güncelleme işlemi başarıyla tamamlandı!");

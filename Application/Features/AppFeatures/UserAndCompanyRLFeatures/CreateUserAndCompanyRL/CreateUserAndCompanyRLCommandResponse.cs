using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.UserAndCompanyRLFeatures.CreateUserAndCompanyRL
{
    public sealed record CreateUserAndCompanyRLCommandResponse(
     string Message = "Kullanıcı şirkete başarıyla kayıt edildi!");
}

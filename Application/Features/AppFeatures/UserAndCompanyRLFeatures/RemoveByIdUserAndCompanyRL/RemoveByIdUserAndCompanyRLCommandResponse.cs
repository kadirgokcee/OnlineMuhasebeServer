using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.UserAndCompanyRLFeatures.RemoveByIdUserAndCompanyRL;
public sealed record RemoveByIdUserAndCompanyRLCommandResponse(
    string Message = "Kullanıcı şirketten başarıyla çıkartıldı!");

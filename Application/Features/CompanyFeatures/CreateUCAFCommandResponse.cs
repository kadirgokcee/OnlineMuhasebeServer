using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CompanyFeatures
{
    public sealed record CreateUCAFCommandResponse(
        string Message = "Hesap Planı kaydı başarıyla tamamlandı!");
}
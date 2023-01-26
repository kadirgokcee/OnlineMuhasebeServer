using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases
{
    public sealed record MigrateCompanyDatabasesCommandResponse(
        string Message = "Şirketletin database bilgileri migrate edildi!");
}
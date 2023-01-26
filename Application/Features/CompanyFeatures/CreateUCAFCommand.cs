using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CompanyFeatures
{
    public sealed record CreateUCAFCommand(
        string Code,
        string Name,
        string Type,
        string CompanyId) : ICommand<CreateUCAFCommandResponse>;
}
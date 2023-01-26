using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.RoleFeatures.Queries
{
    public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;
}

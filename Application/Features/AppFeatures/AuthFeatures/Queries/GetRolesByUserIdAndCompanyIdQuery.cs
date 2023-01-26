using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.AuthFeatures.Queries;
public sealed record GetRolesByUserIdAndCompanyIdQuery(
    string UserId,
    string CompanyId) : IQuery<GetRolesByUserIdAndCompanyIdQueryResponse>;
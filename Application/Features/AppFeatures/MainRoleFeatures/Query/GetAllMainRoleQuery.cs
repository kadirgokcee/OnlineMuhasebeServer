using Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Query;

public sealed record GetAllMainRoleQuery() : IQuery<GetAllMainRoleQueryResponse>;
using Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.MainRoleFeatures.Query;
public sealed record GetAllMainRoleQueryResponse(
    IList<MainRole> MainRoles);
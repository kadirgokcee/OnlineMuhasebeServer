using Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.CompanyFeatures.Queries;
public sealed record GetAllCompanyQueryResponse(
    List<Company> Companies);
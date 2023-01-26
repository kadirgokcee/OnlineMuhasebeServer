using Domain.CompanyEntities;
using Domain.Repositories.CompanyDbContext;
using Persistance.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CompanyDbContext.UCAFRepositories
{
    public sealed class UCAFQueryRepository : CompanyDbQueryRepository<UniformChartOfAccount>, IUCAFQueryRepository
    {
    }
}
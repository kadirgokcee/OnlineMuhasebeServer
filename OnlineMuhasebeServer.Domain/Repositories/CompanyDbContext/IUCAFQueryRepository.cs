using Domain.CompanyEntities;
using Domain.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.CompanyDbContext
{
    public interface IUCAFQueryRepository : ICompanyDbQueryRepository<UniformChartOfAccount>
    {
    }
}
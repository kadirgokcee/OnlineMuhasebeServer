using Domain.AppEntities;
using Domain.Repositories.AppDbContext.CompanyRepositories;
using Domain.Repositories.GenericRepositories.AppDbContext;
using Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppDbContext.CompanyRepositories;
public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
{
    public CompanyCommandRepository(Context.AppDbContext context) : base(context)
    {
    }
}
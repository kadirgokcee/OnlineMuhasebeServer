using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleReporistories;
using Domain.Repositories.GenericRepositories.AppDbContext;
using Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppDbContext.MainRoleRepositories;
public sealed class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
{
    public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
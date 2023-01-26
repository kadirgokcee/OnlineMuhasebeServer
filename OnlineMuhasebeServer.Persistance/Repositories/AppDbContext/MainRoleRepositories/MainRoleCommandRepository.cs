using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleReporistories;
using Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Persistance.Repositories.AppDbContext.MainRoleRepositories;
public sealed class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
{
    public MainRoleCommandRepository(Context.AppDbContext context) : base(context) { }
}
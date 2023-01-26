using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
{
    public MainRoleAndUserRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
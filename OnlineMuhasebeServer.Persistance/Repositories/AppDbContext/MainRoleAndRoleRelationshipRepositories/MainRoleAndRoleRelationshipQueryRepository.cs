using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
{
    public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
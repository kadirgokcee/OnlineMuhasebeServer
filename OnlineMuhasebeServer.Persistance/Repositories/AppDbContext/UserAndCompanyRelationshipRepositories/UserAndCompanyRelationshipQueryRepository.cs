using Domain.AppEntities;
using Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Persistance.Repositories.GenericRepositories.AppDbContext;

namespace Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
{
    public UserAndCompanyRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
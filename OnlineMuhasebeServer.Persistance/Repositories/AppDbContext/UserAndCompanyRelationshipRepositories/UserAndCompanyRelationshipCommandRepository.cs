using Domain.AppEntities;
using Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Domain.Repositories.GenericRepositories.AppDbContext;
using Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
{
    public UserAndCompanyRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
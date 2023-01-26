using Domain.AppEntities;
using Domain.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
public interface IUserAndCompanyRelationshipQueryRepository : IAppQueryRepository<UserAndCompanyRelationship>
{

}

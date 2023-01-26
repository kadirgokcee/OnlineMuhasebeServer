using Domain.AppEntities;
using Domain.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
public interface IMainRoleAndRoleRelationshipCommandRepository : IAppCommandRepository<MainRoleAndRoleRelationship>
{

}
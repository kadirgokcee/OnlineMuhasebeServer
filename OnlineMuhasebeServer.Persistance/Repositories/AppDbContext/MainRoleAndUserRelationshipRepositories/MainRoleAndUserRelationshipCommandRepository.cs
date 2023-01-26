using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Domain.Repositories.GenericRepositories.AppDbContext;
using Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipCommandRepository
{
    public MainRoleAndUserRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
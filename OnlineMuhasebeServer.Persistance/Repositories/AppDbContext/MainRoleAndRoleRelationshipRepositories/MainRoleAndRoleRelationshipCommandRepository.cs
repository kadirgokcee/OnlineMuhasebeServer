using Domain.AppEntities;
using Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Domain.Repositories.GenericRepositories.AppDbContext;
using Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
public class MainRoleAndRoleRelationshipCommandRepository : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipCommandRepository
{
    public MainRoleAndRoleRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
}
using Application.Services.AppServices;
using Application.Services.CompanyServices;
using Domain.Repositories.AppDbContext.CompanyRepositories;
using Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Domain.Repositories.AppDbContext.MainRoleReporistories;
using Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Domain.Repositories.CompanyDbContext;
using Domain.UnitOfWorks;
using Domain;
using Persistance.Repositories.AppDbContext.CompanyRepositories;
using Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using Persistance.Repositories.AppDbContext.MainRoleRepositories;
using Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using Persistance.Services.AppServices;
using Persistance.Services.CompanyServices;
using Persistance.UnitOfWorks;
using Persistance;

namespace WebAPI.Configurations;
public class PersistanceDIServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        #region Context UnitOfWork
        services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
        services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
        services.AddScoped<IContextService, ContextService>();
        #endregion

        #region Services
        #region CompanyDbContext
        services.AddScoped<IUCAFService, UCAFService>();
        //CompanyServiceDISpot
        #endregion

        #region AppDbContext
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IMainRoleService, MainRoleService>();
        services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
        services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
        services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
        services.AddScoped<IAuthService, AuthService>();
        //AppServiceDISpot
        #endregion
        #endregion

        #region Repositories
        #region CompanyDbContext
        services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
        services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
        //CompanyRepositoryDISpot
        #endregion


        #region AppDbContext
        services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
        services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
        services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
        services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
        services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
        services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
        services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
        services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
        services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
        services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();
        //AppRepositoryDISpot
        #endregion
        #endregion
    }
}
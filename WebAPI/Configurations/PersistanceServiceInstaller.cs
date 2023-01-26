using Domain.AppEntities.Identity;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Persistance.Context;

namespace WebAPI.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {
        private const string SectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(SectionName);

            services.AddDbContext<AppDbContext>(options =>
         options.UseSqlServer(connectionString));
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            //services.AddAutoMapper(typeof(AssemblyReference).Assembly);
        }
    }
}
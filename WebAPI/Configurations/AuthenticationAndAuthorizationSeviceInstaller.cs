using Microsoft.AspNetCore.Authentication.JwtBearer;
using WebAPI.OptionsSetup;

namespace WebAPI.Configurations
{
    public class AuthenticationAndAuthorizationSeviceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionsSetup>();
            services.ConfigureOptions<JwtBearerOptionsSetup>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();
        }
    }
}
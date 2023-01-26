using Domain.AppEntities.Identity;
using Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AppServices;

public interface IAuthService
{
    Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName);
    Task<bool> CheckPasswordAsync(AppUser user, string password);
    Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId);
    Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId);
}
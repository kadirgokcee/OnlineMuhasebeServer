using Domain.Abstractions;
using Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AppEntities;
public class UserAndCompanyRelationship : Entity
{
    public UserAndCompanyRelationship()
    {

    }

    public UserAndCompanyRelationship(string id, string appUserId, string companyId) : base(id)
    {
        AppUserId = appUserId;
        CompanyId = companyId;
    }

    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("Company")]
    public string CompanyId { get; set; }
    public Company Company { get; set; }
}

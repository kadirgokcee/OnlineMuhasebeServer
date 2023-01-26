using Domain.Abstractions;
using Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AppEntities;

public sealed class MainRoleAndUserRelationship : Entity
{
    public MainRoleAndUserRelationship()
    {

    }

    public MainRoleAndUserRelationship(string id, string userId, string mainRoleId, string companyId) : base(id)
    {
        UserId = userId;
        CompanyId = companyId;
        MainRoleId = mainRoleId;
    }

    [ForeignKey("AppUser")]
    public string UserId { get; set; }
    public AppUser AppUser { get; set; }

    [ForeignKey("MainRole")]
    public string MainRoleId { get; set; }
    public MainRole MainRole { get; set; }

    [ForeignKey("Company")]
    public string CompanyId { get; set; }
    public Company Company { get; set; }
}
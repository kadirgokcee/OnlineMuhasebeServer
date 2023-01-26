using Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Application.Features.CompanyFeatures;
using AutoMapper;
using Domain.AppEntities;
using Domain.AppEntities.Identity;
using Domain.CompanyEntities;

namespace Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyCommand, Company>();
            CreateMap<CreateUCAFCommand, UniformChartOfAccount>();
            CreateMap<CreateRoleCommand, AppRole>();
        }
    }
}
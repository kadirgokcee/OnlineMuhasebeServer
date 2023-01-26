using Application.Messaging;
using Application.Services.AppServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppFeatures.CompanyFeatures.Queries;
public sealed class GetAllCompanyQueryHandler : IQueryHander<GetAllCompanyQuery, GetAllCompanyQueryResponse>
{
    private readonly ICompanyService _companyService;

    public GetAllCompanyQueryHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        var result = _companyService.GetAll();
        return new GetAllCompanyQueryResponse(await result.ToListAsync());
    }
}
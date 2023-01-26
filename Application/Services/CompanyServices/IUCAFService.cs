using Application.Features.CompanyFeatures;
using Domain.CompanyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanyServices;

public interface IUCAFService
{
    Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);

    Task<UniformChartOfAccount> GetByCode(string code, CancellationToken cancellationToken);
}

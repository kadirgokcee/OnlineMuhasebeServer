using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitOfWorks;

public interface ICompanyDbUnitOfWork : IUnitOfWork
{
    void SetDbContextInstance(DbContext context);
}
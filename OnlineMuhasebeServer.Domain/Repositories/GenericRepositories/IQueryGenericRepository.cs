using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.GenericRepositories;

public interface IQueryGenericRepository<T>
    where T : Entity
{
    IQueryable<T> GetAll(bool isTracking = true);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
    Task<T> GetById(string id, bool isTracking = true);
    Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression, CancellationToken cancellationToken, bool isTracking = true);
    Task<T> GetFirst(bool isTracking = true);
}
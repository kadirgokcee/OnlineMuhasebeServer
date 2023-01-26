using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.GenericRepositories;

public interface ICommandGenericRepository<T>
    where T : Entity
{
    Task AddAsync(T entity, CancellationToken cancellationToken);
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
    void Update(T entity);
    void UpdateRange(IEnumerable<T> entities);
    Task RemoveById(string id);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}
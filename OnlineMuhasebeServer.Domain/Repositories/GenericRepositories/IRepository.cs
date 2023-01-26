using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.GenericRepositories;

public interface IRepository<T>
    where T : Entity
{
    DbSet<T> Entity { get; set; }
}
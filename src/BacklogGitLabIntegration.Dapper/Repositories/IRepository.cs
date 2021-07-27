using BacklogGitLabIntegration.Core.Shared.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BacklogGitLabIntegration.Dapper.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        bool Add(TEntity entity);

        Task<bool> AddAsync(TEntity entity);

        IEnumerable<TEntity> Fetch(Func<TEntity, bool> predicate = null);
    }
}

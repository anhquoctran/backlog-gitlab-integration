using BacklogGitLabIntegration.Core.Shared.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace BacklogGitLabIntegration.Dapper.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity: Entity
    {
        private readonly DbConnection _dbConnection;

        public Repository(DbConnection connection)
        {
            this._dbConnection = connection;
        }

        public bool Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Fetch(Func<TEntity, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}

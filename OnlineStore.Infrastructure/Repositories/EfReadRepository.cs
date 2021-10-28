using System;
using Ardalis.Specification.EntityFrameworkCore;
using OnlineStore.Core.Interfaces;
using OnlineStore.Core.Interfaces.Repositories;
using OnlineStore.Infrastructure.Data;

namespace OnlineStore.Infrastructure.Repositories
{
    public class EfReadRepository<T> : RepositoryBase<T>, IAsyncReadRepository<T> where T : class, IAggregateRoot
    {
        private readonly CatalogDbContext _dbContext;

        public EfReadRepository(CatalogDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        // Not required to implement anything. Add additional functionalities if required.
    }
}

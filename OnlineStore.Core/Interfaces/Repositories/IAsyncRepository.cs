using System;
using Ardalis.Specification;

namespace OnlineStore.Core.Interfaces.Repositories
{
    public interface IAsyncRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
    {
    }

    public interface IAsyncReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}

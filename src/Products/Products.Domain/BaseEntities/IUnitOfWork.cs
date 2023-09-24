namespace Products.Domain.BaseEntities;

public interface IUnitOfWork : IDisposable
{
    Task BeginTransaction();
    Task CommitAsync();
    Task RollbackAsync();
}

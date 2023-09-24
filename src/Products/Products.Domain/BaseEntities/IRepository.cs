namespace Products.Domain.BaseEntities;

public interface IRepository<T> where T : Entity
{
    Task<Guid> CreateAsync(T entity);
    Task<T> GetByIdAsync(Guid id);
}

namespace EBOS.Core.Primitives.Interfaces;

public interface IRepository<T> where T : class
{
    Task AddAsync(T entity);

    void Update(T entity);

    Task<T?> GetByIdAsync(long id);
    
    Task<IList<T>> GetAllAsync();

    Task SaveChangesAsync(CancellationToken token = default);
}
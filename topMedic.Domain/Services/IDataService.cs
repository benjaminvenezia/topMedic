namespace topMedic.Domain.Services;
public interface IDataService<T>
{
    Task<IEnumerable<T>> GetAll();

    Task<IEnumerable<T>> Get(int id);

    Task<T> Create(T entity);

    Task<T> Update(int id, T entity);

    Task<bool> Delete(int id);
}
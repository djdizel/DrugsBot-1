namespace Application.Interfaces.Repos;
//Репозиторий на запись
public interface IWriteRepos<T> where T : class
{
    //Репозиторий для чтения
    IReadRepos<T> ReadRepos { get; }
    
    /// <summary>
    /// Метод для добавления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    /// <summary>
    /// Метод для обновления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
    /// <summary>
    /// Метод для удаления сущности
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
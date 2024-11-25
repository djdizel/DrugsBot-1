using Microsoft.AspNetCore.OData.Query;

namespace Application.Interfaces.Repos;
//Репозиторий на чтение 
public interface IReadRepos<T> where T : class
{
    //Получение сущности по id
    Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    
    //Получение запроса с помощью OData
    Task<IQueryable<T>> GetQuerybleAsync(ODataQueryOptions<T> queryOptions,CancellationToken cancellationToken = default);
}
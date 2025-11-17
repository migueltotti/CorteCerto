using CorteCerto.Application.Common;

namespace CorteCerto.Domain.Base;

public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
{
    void CleanChageTracker();
    void AttachObject(object obj);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(object id);
    Task<PagedResult<TEntity>> Select(IList<string>? includes = null, int pageSize = 50, int pageNumber = 1, CancellationToken token = default);
    Task<TEntity?> Select(object id, IList<string>? includes = null, CancellationToken token = default);
}

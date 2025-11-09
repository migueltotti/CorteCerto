using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Base;

public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
{
    void CleanChageTracker();
    void AttachObject(object obj);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(object id);
    Task<IList<TEntity>> Select(IList<string>? includes = null, CancellationToken token = default);
    Task<TEntity> Select(object id, IList<string>? includes = null, CancellationToken token = default);
}

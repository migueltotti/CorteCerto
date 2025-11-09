using CorteCerto.Domain.Base;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CorteCerto.Infrastructure.Repositories;

public class BaseRepository<TEntity, TIdType>(CorteCertoDbContext context)
    : IBaseRepository<TEntity> where TEntity : BaseEntity<TIdType>
{
    public void AttachObject(object obj)
    {
        context.Attach(obj);
    }

    public void CleanChageTracker()
    {
        context.ChangeTracker.Clear();
    }

    public void Delete(object id)
    {
        context.Set<TEntity>().Remove((TEntity)id);
        context.SaveChanges();
    }

    public void Insert(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);
        context.SaveChanges();
    }

    public async Task<IList<TEntity>> Select(IList<string>? includes = null, CancellationToken token = default)
    {
        var baseQuery = context.Set<TEntity>().AsQueryable();

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                baseQuery = baseQuery.Include(include);
            }
        }
        return await baseQuery.ToListAsync(token);
    }

    public async Task<TEntity> Select(object id, IList<string>? includes = null, CancellationToken token = default)
    {
        var baseQuery = context.Set<TEntity>().AsQueryable();

        if (includes is not null)
        {
            foreach (var include in includes)
            {
                baseQuery = baseQuery.Include(include);
            }
        }
        return await baseQuery.FirstOrDefaultAsync(o => o.Id.Equals((TIdType)id), token);
    }

    public void Update(TEntity entity)
    {
        context.Set<TEntity>().Update(entity);
        context.SaveChanges();
    }
}

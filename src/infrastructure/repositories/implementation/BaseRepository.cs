using System.Linq.Expressions;
using Biogenom_test.domain.models.interfaces;
using Biogenom_test.infrastructure.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.repositories;

public abstract class BaseRepository<T>(DbContext context) : IRepository<T> where T : class, IDbModel
{
    public virtual IQueryable<T> GetAll()
        => context.Set<T>().Where(t => t.DeletedAt == null).AsQueryable();

    public virtual IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter)
        => context.Set<T>().Where(t => t.DeletedAt == null).Where(filter);


    public virtual async Task<T?> GetOneAsync(Expression<Func<T, bool>> filter)
        => await context.Set<T>().Where(t => t.DeletedAt == null).FirstOrDefaultAsync(filter);
}

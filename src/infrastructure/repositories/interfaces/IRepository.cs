using System.Linq.Expressions;
using Biogenom_test.domain.models.interfaces;

namespace Biogenom_test.infrastructure.repositories.interfaces;

public interface IRepository<T> where T : class, IDbModel
{
    public IQueryable<T> GetAll();
    public IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter);
    
    public Task<T?> GetOneAsync(Expression<Func<T, bool>> filter);
}

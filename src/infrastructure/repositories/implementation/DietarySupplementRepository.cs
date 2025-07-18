using System.Linq.Expressions;
using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.repositories;

public class DietarySupplementRepository(DbContext context) : BaseRepository<DietarySupplement>(context)
{
    public override IQueryable<DietarySupplement> GetAll()
        => base.GetAll()
            .Include(i => i.Indicators)
            .AsQueryable();
    
    public override IQueryable<DietarySupplement> GetByFilter(Expression<Func<DietarySupplement, bool>> filter)
        => base.GetByFilter(filter)
            .Include(i => i.Indicators)
            .AsQueryable();
    
    public override async Task<DietarySupplement?> GetOneAsync(Expression<Func<DietarySupplement, bool>> filter)
        => await context.Set<DietarySupplement>()
            .Include(i => i.Indicators)
            .Where(t => t.DeletedAt == null)
            .FirstOrDefaultAsync(filter);
}

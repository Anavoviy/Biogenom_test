using System.Linq.Expressions;
using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.repositories;

public class FormRepository(DbContext context) : BaseRepository<Form>(context)
{
    public override IQueryable<Form> GetAll()
     => context.Set<Form>()
            .Include(i => i.Indicators)
            .Include(i => i.DietarySupplements);

    public override IQueryable<Form> GetByFilter(Expression<Func<Form, bool>> filter)
        => context.Set<Form>()
            .Include(i => i.Indicators)
            .Include(i => i.DietarySupplements);

    public override async Task<Form?> GetOneAsync(Expression<Func<Form, bool>> filter)
        => await context.Set<Form>()
            .Include(i => i.Indicators)
            .Include(i => i.DietarySupplements)
            .Where(t => t.DeletedAt == null)
            .FirstOrDefaultAsync(filter);
}

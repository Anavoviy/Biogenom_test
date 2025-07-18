using System.Linq.Expressions;
using Biogenom_test.domain.models;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.infrastructure.repositories.postgreSql.repositories;

public class IndicatorFormRepository(DbContext context) : BaseRepository<IndicatorForm>(context)
{
    public override IQueryable<IndicatorForm> GetAll()
        => context.Set<IndicatorForm>()
            .Include(i => i.Indicator);

    public override IQueryable<IndicatorForm> GetByFilter(Expression<Func<IndicatorForm, bool>> filter)
        => context.Set<IndicatorForm>()
            .Include(i => i.Indicator);
}

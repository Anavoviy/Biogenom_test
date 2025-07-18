using Biogenom_test.application.DTOs;
using Biogenom_test.domain.logics.interfaces;
using Biogenom_test.domain.models;
using Biogenom_test.infrastructure.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.domain.logics.implementation;

public class IndicatorService(IRepository<IndicatorForm> repIndicators, IRepository<DietarySupplement> repDietarySupplements) : IIndicatorService
{
    public async Task<IEnumerable<IndicatorDTO>> GetLowIndicators()
    {
        var result = repIndicators.GetByFilter(
            i => i.FactValue < i.Indicator.MinStandart
        );

        if (!result.Any())
            return new List<IndicatorDTO>();

        return await result.Select(i => (IndicatorDTO)i).ToListAsync();
    }

    public async Task<IEnumerable<IndicatorDTO>> GetNormalIndicators()
    {
        var result = repIndicators.GetByFilter(
            i => i.FactValue >= i.Indicator.MinStandart
        );

        if (!result.Any())
            return new List<IndicatorDTO>();

        return await result.Select(i => (IndicatorDTO)i).ToListAsync();
    }

    public async Task<IEnumerable<NewIndicatorDTO>> GetNewIndicators()
    {
        var indicators = await (repIndicators.GetByFilter(
            i => i.FactValue < i.Indicator.MinStandart
        )).ToArrayAsync();
        var dietarySupplements = repDietarySupplements.GetAll();
        
        if (indicators.Length == 0 || !dietarySupplements.Any())
            return new List<NewIndicatorDTO>();

        Dictionary<int, decimal> values = new();
        foreach (var dietarySupplement in dietarySupplements)
        foreach (var indicator in dietarySupplement.Indicators)
            if (!values.ContainsKey(indicator.IndicatorId))
                values.Add(indicator.IndicatorId, indicator.Value);
            else
                values[indicator.IndicatorId] += indicator.Value;

        NewIndicatorDTO[] result = new NewIndicatorDTO[indicators.Count()];
        for (int i = 0; i < indicators.Length; i++)
        {
            var indicator = indicators[i];
            result[i] = NewIndicatorDTO.Create(indicator, values[indicator.IndicatorId]);
        }
        
        return result;
    }
}

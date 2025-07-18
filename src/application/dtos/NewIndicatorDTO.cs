using System.Runtime.CompilerServices;
using Biogenom_test.domain.models;

namespace Biogenom_test.application.DTOs;

public record NewIndicatorDTO()
{
    public int IndicatorId { get; set; }
    public string Name { get; set; }
    public decimal FactValue { get; set; }
    public decimal FromTheSet { get; set; }
    public decimal? FromFood { get; set; }

    public static NewIndicatorDTO Create(IndicatorForm indicatorForm, decimal fromTheSet)
        => new()
        {
            IndicatorId = indicatorForm.IndicatorId,
            Name = indicatorForm.Indicator.Name,
            FactValue = indicatorForm.FactValue,
            FromTheSet = fromTheSet,
            FromFood = indicatorForm.Indicator.MinStandart - indicatorForm.FactValue - fromTheSet
        };
};

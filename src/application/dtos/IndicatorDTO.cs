using Biogenom_test.domain.models;

namespace Biogenom_test.application.DTOs;

public record IndicatorDTO()
{
    public int IndicatorId { get; set; }
    public string Name { get; set; }
    public decimal FactValue { get; set; }
    public decimal MinStandart { get; set; }
    public decimal? MaxStandart { get; set; }

    public static implicit operator IndicatorDTO(IndicatorForm indicatorForm)
        => new()
        {
            IndicatorId = indicatorForm.IndicatorId,
            Name = indicatorForm.Indicator.Name,
            FactValue = indicatorForm.FactValue,
            MinStandart = indicatorForm.Indicator.MinStandart,
            MaxStandart = indicatorForm.Indicator.MaxStandart
        };
}

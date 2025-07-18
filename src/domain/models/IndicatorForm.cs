using Biogenom_test.domain.models.baseModels;

namespace Biogenom_test.domain.models;

public class IndicatorForm : DbModel
{
    public int IndicatorId { get; set; }
    public decimal FactValue { get; set; }

    public virtual Indicator Indicator { get; set; } = null!;
}

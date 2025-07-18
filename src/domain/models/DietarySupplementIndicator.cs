using Biogenom_test.domain.models.baseModels;

namespace Biogenom_test.domain.models;

public class DietarySupplementIndicator : DbModel
{
    public Guid DietarySupplementId { get; set; }
    public int IndicatorId { get; set; }

    public decimal Value { get; set; }
    
    public virtual DietarySupplement DietarySupplement { get; set; } = null!;
    public virtual Indicator Indicator { get; set; } = null!;
}

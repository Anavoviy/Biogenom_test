using Biogenom_test.domain.models.baseModels;

namespace Biogenom_test.domain.models;

public class Form : DbModel
{
    public Guid Id { get; set; }
    
    public virtual ICollection<IndicatorForm> Indicators { get; set; } = new List<IndicatorForm>();
    public virtual ICollection<DietarySupplement> DietarySupplements { get; set; } = new List<DietarySupplement>();
}

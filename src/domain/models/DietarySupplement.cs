using Biogenom_test.domain.models.baseModels;

namespace Biogenom_test.domain.models;

public class DietarySupplement : DbModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    
    public virtual ICollection<DietarySupplementIndicator> Indicators { get; set; } = new List<DietarySupplementIndicator>();
}

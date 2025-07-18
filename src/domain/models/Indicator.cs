using Biogenom_test.domain.models.baseModels;
using Biogenom_test.domain.models.interfaces;

namespace Biogenom_test.domain.models;

public class Indicator : DbModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal MinStandart { get; set; }
    public decimal? MaxStandart { get; set; } = null!;
}

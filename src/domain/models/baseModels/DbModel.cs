using Biogenom_test.domain.models.interfaces;

namespace Biogenom_test.domain.models.baseModels;

public class DbModel : IDbModel
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

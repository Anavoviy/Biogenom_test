using System.Data;

namespace Biogenom_test.domain.models.interfaces;

public interface IDbModel
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

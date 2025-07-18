using Biogenom_test.application.DTOs;

namespace Biogenom_test.domain.logics.interfaces;

public interface IDietarySupplementsService
{
    Task<IEnumerable<DietarySupplementsDTO>> GetAll();
}

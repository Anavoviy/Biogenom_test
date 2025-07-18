using Biogenom_test.application.DTOs;
using Biogenom_test.domain.logics.interfaces;
using Biogenom_test.domain.models;
using Biogenom_test.infrastructure.repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biogenom_test.domain.logics.implementation;

public class DietarySupplementsService(IRepository<DietarySupplement> repDietarySupplements) : IDietarySupplementsService
{
    public async Task<IEnumerable<DietarySupplementsDTO>> GetAll()
    {
        var result = repDietarySupplements.GetAll();

        if (!result.Any())
            return new List<DietarySupplementsDTO>();

        return await result.Select(i => (DietarySupplementsDTO)i).ToListAsync();
    }
}

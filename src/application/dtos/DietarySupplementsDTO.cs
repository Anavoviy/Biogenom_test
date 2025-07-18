using Biogenom_test.domain.models;

namespace Biogenom_test.application.DTOs;

public record DietarySupplementsDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }

    public static implicit operator DietarySupplementsDTO(DietarySupplement model)
        => new()
        {
            Id = model.Id,
            Name = model.Name,
            ImageUrl = model.ImageUrl
        };
}

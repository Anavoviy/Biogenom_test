using Biogenom_test.application.DTOs;
using Biogenom_test.domain.logics.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biogenom_test.application.RESTcontrollers;

[ApiController]
[Route("api/dietary_supplements")]
public class DietarySupplementsController(IDietarySupplementsService dietarySupplementsService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<DietarySupplementsDTO>>> GetAll()
    {
        var result = await dietarySupplementsService.GetAll();
        return !result.Any() 
            ? NoContent()
            : Ok();
    }
}

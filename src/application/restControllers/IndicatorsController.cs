using Biogenom_test.application.DTOs;
using Biogenom_test.domain.logics.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biogenom_test.application.RESTcontrollers;

[ApiController]
[Route("api/indicators")]
public class IndicatorsController(IIndicatorService indicatorService): ControllerBase
{
    [HttpGet("low")]
    public async Task<ActionResult<IEnumerable<IndicatorDTO>>> GetLowIndicators()
    {
        var result = await indicatorService.GetLowIndicators();
        return !result.Any() 
            ? NoContent() 
            : Ok(result);
    }
    
    [HttpGet("normal")]
    public async Task<ActionResult<IEnumerable<IndicatorDTO>>> GetNormalIndicators()
    {
        var result = await indicatorService.GetNormalIndicators();
        return !result.Any() 
            ? NoContent() 
            : Ok(result);
    }

    [HttpGet("new")]
    public async Task<ActionResult<IEnumerable<NewIndicatorDTO>>> GetNewIndicators()
    {
        var result = await indicatorService.GetNewIndicators();
        return !result.Any() 
            ? NoContent() 
            : Ok(result);
    }

    
}

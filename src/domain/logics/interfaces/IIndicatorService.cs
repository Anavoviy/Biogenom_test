using Biogenom_test.application.DTOs;

namespace Biogenom_test.domain.logics.interfaces;

public interface IIndicatorService
{
    Task<IEnumerable<IndicatorDTO>> GetLowIndicators();
    Task<IEnumerable<IndicatorDTO>> GetNormalIndicators();
    Task<IEnumerable<NewIndicatorDTO>> GetNewIndicators();
}

using Application.Models;

namespace Application.Services;

public interface ICityService
{
    Task<City?> GetCityByFiasAsync(Guid fias);
}
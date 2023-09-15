using Application.Models;

namespace Application.Services;

public interface ICityService
{
    Task<List<City>?> GetCityByFiasAsync(Guid fias);
}
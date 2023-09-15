using System.Net.Http.Headers;
using System.Text.Json;
using Application.Models;

namespace Application.Services;

public class CityService : ICityService
{
    private readonly string _defaultCityUrl
        = "http://integration.cdek.ru";
    
    public async Task<City?> GetCityByFiasAsync(Guid fiasGuid)
    {
        using var client = new HttpClient
        {
            BaseAddress = new Uri(_defaultCityUrl)
        };
        
        client.DefaultRequestHeaders
            .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var response = await client
            .GetAsync($"/v1/location/cities/json?{nameof(fiasGuid)}={fiasGuid}");

        var content = await response.Content.ReadAsStringAsync();
        
        if (content.Length == 0)
        {
            throw new ArgumentNullException(nameof(content));
        }

        return JsonSerializer.Deserialize<List<City>>(content)?
            .First();
    }
}
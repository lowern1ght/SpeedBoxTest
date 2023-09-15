using System.Text.Json.Serialization;

namespace Application.Models;

public class City
{
    [JsonPropertyName("cityName")]
    public string? CityName { get; set; }

    [JsonPropertyName("cityCode")]
    public string? CityCode { get; set; }

    [JsonPropertyName("cityUuid")]
    public string? CityUuid { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("regionCode")]
    public string? RegionCode { get; set; }

    [JsonPropertyName("regionFiasGuid")]
    public string? RegionFiasGuid { get; set; }
}
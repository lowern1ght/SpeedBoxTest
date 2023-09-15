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

    [JsonPropertyName("subRegion")]
    public string? SubRegion { get; set; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("kladr")]
    public string? Kladr { get; set; }

    [JsonPropertyName("fiasGuid")]
    public string? FiasGuid { get; set; }

    [JsonPropertyName("paymentLimit")]
    public double? PaymentLimit { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}
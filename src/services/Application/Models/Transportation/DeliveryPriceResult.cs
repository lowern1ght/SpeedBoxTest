using System.Text.Json.Serialization;

namespace Application.Models.Transportation;

public class DeliveryPriceResult
{
    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("deliveryPeriodMin")]
    public int? DeliveryPeriodMin { get; set; }

    [JsonPropertyName("deliveryPeriodMax")]
    public int? DeliveryPeriodMax { get; set; }

    [JsonPropertyName("deliveryDateMin")]
    public string DeliveryDateMin { get; set; }

    [JsonPropertyName("deliveryDateMax")]
    public string DeliveryDateMax { get; set; }

    [JsonPropertyName("tariffId")]
    public string TariffId { get; set; }

    [JsonPropertyName("priceByCurrency")]
    public int? PriceByCurrency { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }
}
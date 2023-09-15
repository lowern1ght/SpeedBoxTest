using System.Text.Json.Serialization;

namespace Application.Models.Transportation;

public class DeliveryRequest
{
    [JsonPropertyName("version")] public string Version { get; set; } = "1.5";
    [JsonPropertyName("dateExecute")] public DateTime? DateExecute { get; set; } = DateTime.Now;
    
    [JsonPropertyName("senderCityId")] public long SenderCityId { get; set; }
    [JsonPropertyName("senderCityPostCode")] public long SenderCityPostCode { get; set; }
    
    [JsonPropertyName("receiverCityId")] public long ReceiverCityId { get; set; }
    [JsonPropertyName("receiverCityPostCode")] public long ReceiverCityPostCode { get; set; }
    
    [JsonPropertyName("goods")]
    public Dimensions? Goods { get; init; }
}
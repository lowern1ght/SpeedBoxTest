using System.Text.Json.Serialization;

namespace Application.Models;

public class Transportation
{
    [JsonPropertyName("version")] public string Version { get; set; } = "1.5";
    [JsonPropertyName("dateExecute")] public DateTime? DateExecute { get; set; } = DateTime.Now;
    
    [JsonPropertyName("senderCityId")] public long SenderCityId { get; set; }
    [JsonPropertyName("senderCityPostCode")] public long SenderCityPostCode { get; set; }
    
    [JsonPropertyName("receiverCityId")] public long ReceiverCityId { get; set; }
    [JsonPropertyName("receiverCityPostCode")] public long ReceiverCityPostCode { get; set; }
    
    public Dimensions Goods { get; init; }
}
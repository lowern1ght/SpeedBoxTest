using System.Text.Json.Serialization;

namespace Application.Models.Transportation;

public class DeliveryModel
{
    public Guid FiasSender { get; set; }
    public Guid FiasReceiver { get; set; }
    public Dimensions Dimensions { get; set; }
    
    [JsonConstructor]
    public DeliveryModel(Guid fiasSender, Guid fiasReceiver, Dimensions dimensions)
    {
        Dimensions = dimensions;
        FiasSender = fiasSender;
        FiasReceiver = fiasReceiver;
    }
}
using Application.Models.Transportation;

namespace Application.Services;

public class TransportationService : ITransportationService<DeliveryRequest, DeliveryPriceResult>
{
    public Task<DeliveryPriceResult> GetTransportInfo(DeliveryRequest requestModel)
    {
        throw new NotImplementedException();
    }
}
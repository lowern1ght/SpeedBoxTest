using Application.Models.Transportation;

namespace Application.Services.Mediator;

public class DeliveryMediator : IDeliveryMediator<DeliveryModel, int>
{
    private readonly ICityService _cityService;
    private readonly ITransportationService<DeliveryRequest, DeliveryPriceResult> _transportationService;

    public DeliveryMediator(ICityService cityService, 
        ITransportationService<DeliveryRequest, DeliveryPriceResult> transportationService)
    {
        _cityService = cityService;
        _transportationService = transportationService;
    }
    
    public async Task<int> HandleAsync(DeliveryModel requestObject)
    {
        var senderCity = await _cityService.GetCityByFiasAsync(requestObject.FiasSender);
        var receiverCity = await _cityService.GetCityByFiasAsync(requestObject.FiasReceiver);

        if (senderCity is null || receiverCity is null)
        {
            throw new InvalidOperationException(
                "sender or receiver city is null");
        }
        
        var requestModel = new DeliveryRequest()
        {
            SenderCityId = senderCity.CityCode,
            SenderCityPostCode = senderCity.,
            Goods = requestObject.Dimensions,
        }
        
        _transportationService.GetTransportInfo()
    }
}
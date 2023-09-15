using Application.Models.Transportation;
using Application.Services;
using Application.Services.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class TransportationController : Controller
{
    [HttpGet]
    public async Task<int> ExploreDeliveryPriceAsync(
        [FromServices] IDeliveryMediator<DeliveryModel, int> deliveryMediator, [FromQuery] DeliveryModel deliveryModel)
    {
        return await deliveryMediator.HandleAsync(deliveryModel);
    }
}
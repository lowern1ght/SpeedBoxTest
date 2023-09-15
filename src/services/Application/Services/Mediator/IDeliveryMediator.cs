namespace Application.Services.Mediator;

public interface IDeliveryMediator<in TRequestObject, TResult>
{
    Task<TResult> HandleAsync(TRequestObject requestObject);
}
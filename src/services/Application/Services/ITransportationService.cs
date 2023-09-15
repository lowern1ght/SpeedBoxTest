namespace Application.Services;

public interface ITransportationService<in TRequestModel, TResponseModel>
{
    public Task<TResponseModel> GetTransportInfo(TRequestModel requestModel);
}
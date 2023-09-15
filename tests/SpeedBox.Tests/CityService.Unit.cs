using Application.Models;
using Application.Services;
using Newtonsoft.Json;
using Xunit.Abstractions;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SpeedBox.Tests;

public class CityServiceTest
{
    private readonly ITestOutputHelper _output;

    public CityServiceTest(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Theory]
    [InlineData("6965fcac-b7e4-4cab-ab35-a591ed65edf5")]
    [InlineData("8dea00e3-9aab-4d8e-887c-ef2aaa546456")]
    [InlineData("c624753c-9677-474f-881c-7c37910ed220")]
    [InlineData("579da04d-579c-4ef7-8f84-aa63088be55b")]
    public async void Test(Guid fias)
    {
        var result = await (new CityService()
            .GetCityByFiasAsync(fias));
        
        _output.WriteLine(JsonSerializer.Serialize(result));
        Assert.IsType<List<City>?>(result);
    }
}
using System.Linq.Expressions;
using Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders()
    .AddConsole();

builder.Services.AddControllers();

builder.Services
    .AddTransient<ITransportationService, TransportationService>()
    .AddTransient<ICityService, CityService>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer()
        .AddSwaggerGen();
}

var application = builder.Build();

if (application.Environment.IsDevelopment())
{
    application.UseSwagger()
        .UseSwaggerUI();
}

application.UseCors(policyBuilder =>
{
    policyBuilder.AllowAnyHeader()
                 .AllowAnyMethod()
                 .AllowAnyOrigin();
});

application.MapDefaultControllerRoute();

PP.Exec(() => true);

application.Run();

public static class PP
{
    public static void Exec(Func<bool> expression)
    {
        
    }
}
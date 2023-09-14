var builder = WebApplication.CreateBuilder(args);

var application = builder.Build();

application.UseCors(policyBuilder =>
{
    policyBuilder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
});

application.MapDefaultControllerRoute();

application.Run();

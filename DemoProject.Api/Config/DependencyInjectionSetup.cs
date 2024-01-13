namespace DemoProject.Api.Config;

public static class DependencyInjectionSetup
{
    public static WebApplicationBuilder ConfigureDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }
}
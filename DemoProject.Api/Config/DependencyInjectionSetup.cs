using System.Reflection;
using DemoProject.Application.Extensions;

namespace DemoProject.Api.Config;

public static class DependencyInjectionSetup
{
    public static WebApplicationBuilder ConfigureDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddApplication();
        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return builder;
    }
}
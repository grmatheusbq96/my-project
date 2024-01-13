using DemoProject.Api.Config;

namespace DemoProject.Api
{
    public static class Startup
    {
        public static WebApplication Config(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            DependencyInjectionSetup.ConfigureDependencies(builder);

            var app = builder.Build();
            AppConfiguration.ConfigureApp(app);

            return app;
        }
    }
}
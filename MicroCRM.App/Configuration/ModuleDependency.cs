namespace MicroCRM.App.Configuration
{
    public static class ModuleDependency
    {
        public static IServiceCollection AddAppModule(this IServiceCollection services)
        {
            return services.AddScoped<HttpClient>();
        }
    }
}
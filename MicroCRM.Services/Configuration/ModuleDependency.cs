using Microsoft.Extensions.DependencyInjection;

namespace MicroCRM.Services.Configuration
{
    public static class ModuleDependency
    {
        public static IServiceCollection AddServicesModule(this IServiceCollection service)
        {
            return service
                .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ModuleDependency).Assembly));
        }
    }
}
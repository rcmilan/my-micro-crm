using Microsoft.Extensions.DependencyInjection;

namespace MicroCRM.Services.Configuration
{
    public static class ModuleDependency
    {
        public static IServiceCollection AddServiceModule(IServiceCollection service)
        {
            return service;
        }
    }
}
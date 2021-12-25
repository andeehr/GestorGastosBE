using GestorGastosBE.Services.Services;
using GestorGatosBE.Common.Services.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaGastoService, CategoriaGastoService>();
            services.AddScoped<IGastoService, GastoService>();

            return services;
        }
    }
}

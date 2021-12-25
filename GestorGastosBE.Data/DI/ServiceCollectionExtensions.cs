using GestorGastosBE;
using GestorGastosBE.Data;
using GestorGastosBE.Repositories;
using GestorGastosBE.Repository.Interfaces;
using GestorGatosBE.Common.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppUnitOfWork(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GGContext>(x => x.UseSqlServer(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

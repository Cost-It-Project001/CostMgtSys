using CostItArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CostItArchitecture.Infrastructure.Extensions
{
    public static class DenpencyInjection
    {
        public static IServiceCollection ImplementPersistence(this
            IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CostItDbcontext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(CostItDbcontext).Assembly.FullName)), ServiceLifetime.Transient);

            /*services.AddScoped<IMovieRentalDbcontext>(provider =>
                provider.GetRequiredService<MovieRentalDbcontext>());*/

            services.AddScoped<ICostItDbcontext, CostItDbcontext>();

            //Add Service Injections Here


            //Add Repository Injections Here

            return services;
        }
    }
}

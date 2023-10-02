using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using website_backend.Domain.Interfaces;
using website_backend.Infra.Services;
using website_backend.Repository.Connection.Services;

namespace website_backend.Infra.Configuration
{
    public static class Configuration
    {

        public static void ServicesConfiguration(this IServiceCollection services, IConfiguration config) 
        {
            var assembly = Assembly.Load("website-backend.Domain");
            services.AddMediatR(cfg =>
                 cfg.RegisterServicesFromAssembly(assembly));

            services.AddScoped<IGamesService, GamesService>();
            services.AddScoped<IMongoDBUtils, MongoDBUtils>();
            services.AddScoped<ICollectionUtils, CollectionUtils>();
        }
    }
}

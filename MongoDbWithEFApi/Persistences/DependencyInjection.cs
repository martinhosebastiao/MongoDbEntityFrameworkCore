using Microsoft.EntityFrameworkCore;

namespace MongoDbWithEFApi.Persistences;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<MongoDbContext>(options =>
        {
            var database = configuration
                .GetConnectionString("DefaultDatabase") ?? string.Empty;

            var connection = configuration
                .GetConnectionString("DefaultConnection") ?? string.Empty;

            options.UseMongoDB(connection, database);
        });

        return services;
    }
}

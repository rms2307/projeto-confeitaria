using Confeitaria.Api.Infra.ContextDb;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection RegistraDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ConfeitariaContext>(options => options
                .UseSqlite("DataSource=Confeitaria.db;Cache=Shared"));
        }
    }
}

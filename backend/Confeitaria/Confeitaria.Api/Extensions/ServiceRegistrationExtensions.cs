using Confeitaria.Api.Infra.ContextDb;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.Repositories.Base;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.Repositories;
using Confeitaria.Api.Repositories.Base;
using Confeitaria.Api.UseCases.Ingredientes;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection RegistraDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                 .AddDbContextApp()
                 .AddUsesCases()
                 .AddRepositories();
        }

        private static IServiceCollection AddUsesCases(this IServiceCollection services)
        {
            return services
                .AddScoped<IAtualizarIngredienteUseCase, AtualizarIngredienteUseCase>()
                .AddScoped<ICriarIngredienteUseCase, CriarIngredienteUseCase>()
                .AddScoped<IObterTodosIngredienteUseCase, ObterTodosIngredienteUseCase>()
                .AddScoped<IObterUmIngredienteUseCase, ObterUmIngredienteUseCase>()
                .AddScoped<IRemoverIngredienteUseCase, RemoverIngredienteUseCase>();
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IIngredienteRepository, IngredienteRepository>();
        }

        private static IServiceCollection AddDbContextApp(this IServiceCollection services)
        {
            return services.AddDbContext<ConfeitariaContext>(options => options
                .UseSqlite("DataSource=Confeitaria.db;Cache=Shared"));
        }
    }
}

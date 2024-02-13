using Confeitaria.Api.ViewModels.Outputs;

namespace Confeitaria.Api.Interfaces.UseCases.Ingredientes
{
    public interface IObterUmIngredienteUseCase
    {
        Task<IngredienteOutput> ObterAsync(int id);
    }
}

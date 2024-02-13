using Confeitaria.Api.ViewModels.Outputs;

namespace Confeitaria.Api.Interfaces.UseCases.Ingredientes
{
    public interface IObterTodosIngredienteUseCase
    {
        Task<IEnumerable<IngredienteOutput>> ObterTodosAsync();
    }
}

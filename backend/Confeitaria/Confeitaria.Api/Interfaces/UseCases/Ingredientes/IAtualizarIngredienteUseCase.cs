using Confeitaria.Api.ViewModels.Inputs;

namespace Confeitaria.Api.Interfaces.UseCases.Ingredientes
{
    public interface IAtualizarIngredienteUseCase
    {
        Task AtualizarAsync(int id, AtualizarIngredienteInput  input);
    }
}

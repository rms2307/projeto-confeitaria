using Confeitaria.Api.ViewModels.Inputs;

namespace Confeitaria.Api.Interfaces.UseCases.Ingredientes
{
    public interface ICriarIngredienteUseCase
    {
        Task CriarAsync(CriarIngredienteInput input);
    }
}

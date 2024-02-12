using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Inputs;

namespace Confeitaria.Api.UseCases.Ingrediente
{
    public class CriarIngredienteUseCase : ICriarIngredienteUseCase
    {
        private readonly
        Task<int> ICriarIngredienteUseCase.Criar(CriarIngredienteInput input)
        {
            throw new NotImplementedException();
        }
    }
}

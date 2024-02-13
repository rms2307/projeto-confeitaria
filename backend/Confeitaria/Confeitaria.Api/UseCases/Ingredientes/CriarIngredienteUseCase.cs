using Confeitaria.Api.Entities;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Inputs;

namespace Confeitaria.Api.UseCases.Ingredientes
{
    public class CriarIngredienteUseCase(IIngredienteRepository repository) : ICriarIngredienteUseCase
    {
        private readonly IIngredienteRepository _repository = repository;

        public async Task CriarAsync(CriarIngredienteInput input)
        {
            Ingrediente ingrediente = input.ConverterParaIngredienteEntity();

            await _repository.CriarAsync(ingrediente);
        }
    }
}

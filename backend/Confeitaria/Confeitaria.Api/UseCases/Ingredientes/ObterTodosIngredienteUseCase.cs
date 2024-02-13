using Confeitaria.Api.Entities;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Outputs;

namespace Confeitaria.Api.UseCases.Ingredientes
{
    public class ObterTodosIngredienteUseCase(IIngredienteRepository repository) : IObterTodosIngredienteUseCase
    {
        private readonly IIngredienteRepository _repository = repository;

        public async Task<IEnumerable<IngredienteOutput>> ObterTodosAsync()
        {
            IEnumerable<Ingrediente> ingredientes = await _repository.ObterTodosAsync();

            return ingredientes.Select(i => i.ConverterParaIngredienteOutput());
        }
    }
}

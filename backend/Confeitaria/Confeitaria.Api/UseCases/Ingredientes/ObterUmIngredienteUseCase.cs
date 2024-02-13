using Confeitaria.Api.Entities;
using Confeitaria.Api.Exceptions;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Outputs;

namespace Confeitaria.Api.UseCases.Ingredientes
{
    public class ObterUmIngredienteUseCase(IIngredienteRepository repository) : IObterUmIngredienteUseCase
    {
        private readonly IIngredienteRepository _repository = repository;

        public async Task<IngredienteOutput> ObterAsync(int id)
        {
            Ingrediente? ingrediente = await _repository.ObterUmAsync(id);

            return ingrediente == null
                ? throw new NotFoundException($"Ingrediente {id} não encontrado.")
                : ingrediente.ConverterParaIngredienteOutput();
        }
    }
}

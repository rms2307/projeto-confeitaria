using Confeitaria.Api.Entities;
using Confeitaria.Api.Exceptions;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Inputs;

namespace Confeitaria.Api.UseCases.Ingredientes
{
    public class AtualizarIngredienteUseCase(IIngredienteRepository repository) : IAtualizarIngredienteUseCase
    {
        private readonly IIngredienteRepository _repository = repository;

        public async Task AtualizarAsync(int id, AtualizarIngredienteInput input)
        {
            Ingrediente? ingrediente = await _repository.ObterUmAsync(id)
                ?? throw new NotFoundException($"Ingrediente {id} não encontrado.");

            ingrediente.Atualizar(input.Nome, input.UnidadeMedida);

            await _repository.AtualizarAsync(ingrediente);
        }
    }
}

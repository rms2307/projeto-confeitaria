using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Interfaces.UseCases.Ingredientes;

namespace Confeitaria.Api.UseCases.Ingredientes
{
    public class RemoverIngredienteUseCase(IIngredienteRepository repository) : IRemoverIngredienteUseCase
    {
        private readonly IIngredienteRepository _repository = repository;

        public async Task RemoverAsync(int id)
        {
            await _repository.RemoverAsync(id);
        }
    }
}

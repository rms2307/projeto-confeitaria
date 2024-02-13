namespace Confeitaria.Api.Interfaces.UseCases.Ingredientes
{
    public interface IRemoverIngredienteUseCase
    {
        Task RemoverAsync(int id);
    }
}

namespace Confeitaria.Api.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
            Task<IEnumerable<TEntity>> ObterTodosAsync();
            Task<TEntity?> ObterUmAsync(int id);
            Task CriarAsync(TEntity entity);
            Task AtualizarAsync(TEntity entity);
            Task RemoverAsync(int id);
    }
}

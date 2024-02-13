using Confeitaria.Api.Entities;
using Confeitaria.Api.Infra.ContextDb;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Repositories.Base;

namespace Confeitaria.Api.Repositories
{
    public class IngredienteRepository : RepositoryBase<Ingrediente>, IIngredienteRepository
    {
        public IngredienteRepository(ConfeitariaContext context) : base(context) { }
    }
}

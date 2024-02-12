using Confeitaria.Api.Entities;
using Confeitaria.Api.Infra.ContextDb;
using Confeitaria.Api.Interfaces.Repositories;
using Confeitaria.Api.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Repositories
{
    public class IngredienteRepository : RepositoryBase<Ingrediente>, IIngredienteRepository
    {
        public IngredienteRepository(ConfeitariaContext context, DbSet<Ingrediente> entities)
            : base(context, entities) { }
    }
}

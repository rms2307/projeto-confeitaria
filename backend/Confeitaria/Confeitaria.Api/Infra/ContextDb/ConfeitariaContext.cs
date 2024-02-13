using Confeitaria.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Infra.ContextDb
{
    public class ConfeitariaContext(DbContextOptions<ConfeitariaContext> options) : DbContext(options)
    {
        public DbSet<Ingrediente> Ingredientes { get; set; }
    }
}

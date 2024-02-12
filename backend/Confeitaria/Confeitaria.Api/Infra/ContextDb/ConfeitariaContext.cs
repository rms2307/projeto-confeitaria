using Confeitaria.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Infra.ContextDb
{
    public class ConfeitariaContext : DbContext
    {
        public ConfeitariaContext(DbContextOptions<ConfeitariaContext> options) : base(options)
        {
        }

        public DbSet<Ingrediente> Ingredientes { get; set; }
    }
}

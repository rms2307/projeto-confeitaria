﻿using Confeitaria.Api.Infra.ContextDb;
using Confeitaria.Api.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.Api.Repositories.Base
{
    public class RepositoryBase<TEntity>(ConfeitariaContext context) : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ConfeitariaContext _context = context;
        private readonly DbSet<TEntity> _entities = context.Set<TEntity>();

        public async Task<IEnumerable<TEntity>> ObterTodosAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<TEntity?> ObterUmAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task CriarAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(TEntity entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverAsync(int id)
        {
            TEntity? entity = await ObterUmAsync(id);
            if (entity != null)
            {
                _entities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SecureLineSalesApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SecureLineSalesApp.IServices
{
    internal class BaseService<T> : IBaseServices<T> where T : class, IBaseModel, new()
    {
        private readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public bool ExistAsync(string slug, int id)
        {
            var result = _context.Set<T>().FirstOrDefault(x => x.Id != id && x.Slug == slug && x.IsDeleted == 0);
            if (result == null)
                return true;
            return false;
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().Where(x => x.IsDeleted == 0).OrderByDescending(x => x.Id).ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>().Where(x => x.IsDeleted == 0).OrderByDescending(x => x.Id);
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id) => await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == Id && n.IsDeleted == 0);

        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.FirstOrDefaultAsync(n => n.Id == id && n.IsDeleted == 0);
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

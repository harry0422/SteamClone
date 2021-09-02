using SteamClone.Infrastructure.Games.Contexts;
using StreamClone.Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace SteamClone.Infrastructure.Common
{
    public class EFRepositoryBase<TEntity> : IRepository<TEntity, string> where TEntity : class
    {
        private readonly ApplicationContext _context;

        public EFRepositoryBase(ApplicationContext context)
        {
            _context = context;
        }

        public TEntity Get(string key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            _context.Set<TEntity>().Remove(_context.Set<TEntity>().Find(id));

        }
    }
}
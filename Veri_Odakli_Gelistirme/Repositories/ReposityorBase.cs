using Repositories.Contracts;
using StoreApp.Models;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositotyBase<T> where T : class, new(){
        protected readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context){
            _context = context;
        }

        public IQueryable<T> FindAll(bool trachChanges){
            return !trachChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();
        }
    }
}
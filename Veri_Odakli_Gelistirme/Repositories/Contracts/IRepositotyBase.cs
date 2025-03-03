namespace Repositories.Contracts
{
    public interface IRepositotyBase<T>
    {
        IQueryable<T> FindAll(bool trachChanges); 
    }
}
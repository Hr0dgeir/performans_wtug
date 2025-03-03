using Entities.Models;
using Repositories.Contracts;
using StoreApp.Models;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context){

        }
        public IQueryable<Product> GetAllProducts(bool trachChanges) => FindAll(trachChanges);
    }
}
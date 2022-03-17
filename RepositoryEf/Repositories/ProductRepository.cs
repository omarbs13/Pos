using Entities.Interfaces;
using Entities.Pocos;
using RepositoryEf.DataContext;

namespace RepositoryEf.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly Context Context;

        public ProductRepository(Context context) => Context = context;

        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }
    }
}

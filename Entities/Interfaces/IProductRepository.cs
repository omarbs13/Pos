using Entities.Pocos;

namespace Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);

        IEnumerable<Product> GetAll();
    }
}

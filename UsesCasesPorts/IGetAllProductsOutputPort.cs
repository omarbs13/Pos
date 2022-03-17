using Dtos;

namespace UsesCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}

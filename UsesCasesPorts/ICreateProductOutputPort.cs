using Dtos;

namespace UsesCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}

using Dtos;

namespace UsesCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}

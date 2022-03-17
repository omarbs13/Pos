using Dtos;
using Entities.Interfaces;
using UsesCasesPorts;

namespace UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutputPort;


        public GetAllProductsInteractor(IProductRepository productRepository, IGetAllProductsOutputPort createProductInputPort) =>
            (Repository, OutputPort) = (productRepository, createProductInputPort);


        public Task Handle()
        {
            var products = Repository.GetAll().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name
            });
            OutputPort.Handle(products);
            return Task.CompletedTask;
        }
    }
}

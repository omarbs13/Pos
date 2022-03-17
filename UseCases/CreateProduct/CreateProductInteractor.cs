using Dtos;
using Entities.Interfaces;
using Entities.Pocos;
using UsesCasesPorts;

namespace UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateProductOutputPort OutputPort;


        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort createProductInputPort) =>
            (Repository, UnitOfWork, OutputPort) = (productRepository, unitOfWork, createProductInputPort);

        public async Task Handle(CreateProductDTO product)
        {
            Product newProduct = new Product
            {
                Name = product.ProductName
            };
            Repository.CreateProduct(newProduct);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct
            .Name
            });
        }
    }
}

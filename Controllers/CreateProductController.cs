using Dtos;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UsesCasesPorts;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort InputPort;
        readonly ICreateProductOutputPort OutputPort;
        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO productDTO)
        {
            await InputPort.Handle(productDTO);

            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }
    }
}

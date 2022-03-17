using Microsoft.Extensions.DependencyInjection;
using UsesCasesPorts;

namespace Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection service)
        {

            service.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
            service.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            return service;

        }
    }
}

using LaptopStoreSharedLibrary.Models;
using LaptopStoreSharedLibrary.Response;

namespace LaptopStoreClient.Services
{
    public interface IProductService
    {
        Task<ServiceResponse> AddProDuct(Product model);
        Task<List<Product>> GetAllProducts(bool featuredProducts);
    }
}

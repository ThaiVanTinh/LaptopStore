using LaptopStoreSharedLibrary.Models;
using LaptopStoreSharedLibrary.Response;

namespace LaptopStoreServer.Repositories
{
    public interface IProduct
    {
        Task<ServiceResponse> AddProDuct(Product model);
        Task<List<Product>> GetAllProducts(bool featuredProducts);
    }
}

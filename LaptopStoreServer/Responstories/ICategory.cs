using LaptopStoreSharedLibrary.Models;
using LaptopStoreSharedLibrary.Response;

namespace LaptopStoreServer.Repositories
{
    public interface ICategory
    {
        Task<ServiceResponse> AddCategory(Category model);
        Task<List<Product>> GetAllCategories();
    }
}

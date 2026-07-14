using DAL.Models;

namespace DAL.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetAllWithCategory();
    }
}

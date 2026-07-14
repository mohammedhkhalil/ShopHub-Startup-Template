using DAL.Data;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

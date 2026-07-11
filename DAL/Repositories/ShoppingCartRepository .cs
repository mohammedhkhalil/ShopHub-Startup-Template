using DAL.Data;
using DAL.Repositories;

namespace DAL.Models
{
    public class ShoppingCart : GenericRepository<ShoppingCart>
    {
        public ShoppingCart(ApplicationDbContext context) : base(context)
        {
        }
    }
}

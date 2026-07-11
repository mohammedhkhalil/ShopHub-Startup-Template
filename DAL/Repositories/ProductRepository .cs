using DAL.Data;
using DAL.Repositories;

namespace DAL.Models
{
    public class Product : GenericRepository<Product>
    {
        public Product(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using DAL.Data;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

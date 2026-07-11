using DAL.Data;
using DAL.Repositories;

namespace DAL.Models
{
    public class OrderHeader : GenericRepository<OrderHeader>
    {
        public OrderHeader(ApplicationDbContext context) : base(context)
        {
        }
    }
}

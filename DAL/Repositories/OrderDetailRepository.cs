using DAL.Data;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetailRepository>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void Add(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<OrderDetail> IGenericRepository<OrderDetail>.GetAll()
        {
            throw new NotImplementedException();
        }

        OrderDetail IGenericRepository<OrderDetail>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

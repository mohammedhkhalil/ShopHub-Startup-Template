using DAL.Data;

namespace DAL.Models
{
    public class OrderDetail
    {
        public OrderDetail(ApplicationDbContext context) : base(context)
        {
        }

        public int Id { get; set; }

        public int OrderHeaderId { get; set; }
        public IOrderHeader OrderHeader { get; set; }

        public int ProductId { get; set; }
        public IProduct Product { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }


    }
}

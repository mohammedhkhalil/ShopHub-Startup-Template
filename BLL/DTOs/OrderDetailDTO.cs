namespace BLL.DTOs
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }


    }
}

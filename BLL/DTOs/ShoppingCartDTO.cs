namespace BLL.DTOs
{
    public class ShoppingCartDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public string ApplicationUserId { get; set; }
    }
}

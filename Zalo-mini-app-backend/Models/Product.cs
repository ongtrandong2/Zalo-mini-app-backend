namespace Zalo_mini_app_backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string ImageUrl { get; set; } = "https://placehold.co/100x100";
    }
    public class AddUpdateProduct
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string ImageUrl { get; set; } = "https://placehold.co/100x100";
    }
}

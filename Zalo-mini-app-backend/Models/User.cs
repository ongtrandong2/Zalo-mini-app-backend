

namespace Zalo_mini_app_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AvtUrl { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }

    public class AddUpdateUser
    {
        public string Name { get; set; } = string.Empty;
        public string avtURL { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}

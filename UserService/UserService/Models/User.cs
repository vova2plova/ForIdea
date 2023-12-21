using Microsoft.AspNetCore.Identity;
using UserService.Enums;

namespace UserService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public EAccountType AccountType { get; set; }
    }
}

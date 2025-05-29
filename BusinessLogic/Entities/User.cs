using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data.Entities
{
    public enum ClientType { Node, Regular, Premium }
    public class User : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
        public ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}

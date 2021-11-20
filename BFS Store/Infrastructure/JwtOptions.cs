using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace SportStore.Infrastructure
{
    public class JwtOptions
    {
        private const string KEY = "mysupersecret_secretkey!123";
        public const string ISSUER = "https://localhost:5005";
        public const string AUDIENCE = ISSUER;
        public const int LIFETIME = 22;
        public static SymmetricSecurityKey GetKey()
            => new(Encoding.UTF8.GetBytes(KEY));
    }
}
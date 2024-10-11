using Lemoo_pos.Services.Interfaces;

namespace Lemoo_pos.Services
{
    public class AuthService : IAuthService
    {
        public string login(string username, string password)
        {
            return "Hello, "  + username;
        }
    }
}

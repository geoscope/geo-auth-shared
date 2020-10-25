
namespace geo_auth_shared.Interfaces
{
    public interface ISecurityHelper
    {
        string HashPassword(string password, string systemSalt, string userSalt);
    }
}

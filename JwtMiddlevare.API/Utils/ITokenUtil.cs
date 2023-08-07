using JwtMiddlevare.API.Models;

namespace JwtMiddlevare.API.Utils
{
    public interface ITokenUtil
    {
        Task<Tokenresponse> GenerateToken(UserModel user);
    }
}

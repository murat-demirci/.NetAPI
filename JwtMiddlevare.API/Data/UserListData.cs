using JwtMiddlevare.API.Models;

namespace JwtMiddlevare.API.Data
{
    public class UserListData
    {
        public static List<UserModel> UserList = new()
        {
            new UserModel() { Id=1,Name="murat",Email="murat@mail.com",Password="123456",Role="admin"},
            new UserModel() { Id=2,Name="john",Email="john@mail.com",Password="123456",Role="moderator"},
            new UserModel() { Id=3,Name="random",Email="radnom@mail.com",Password="123456",Role="user"},
        };
    }
}

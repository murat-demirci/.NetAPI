namespace JwtMiddleware.API.Context
{
    public class UserHelper
    {
        public static async Task CreateUser()
        {
            MyUsers user = new()
            {
                Name = "murat",
                Password = "123",
                Token = ""
            };
            using (var contex = new RandomContext())
            {
                await contex.Users.AddAsync(user);
                await contex.SaveChangesAsync();
            }
        }
    }
}


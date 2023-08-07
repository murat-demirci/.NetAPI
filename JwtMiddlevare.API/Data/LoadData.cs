using JwtMiddlevare.API.EfContext;

namespace JwtMiddlevare.API.Data
{
    public class LoadData
    {
        private static readonly InMemoryContext _context = InMemoryContext.Singleton;
        public static async Task Load()
        {
            await _context.Users.AddRangeAsync(UserListData.UserList);
            await _context.SaveChangesAsync();
        }
    }
}

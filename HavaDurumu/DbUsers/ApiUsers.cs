using HavaDurumu.Models;

namespace HavaDurumu.DbUsers
{
    public class ApiUsers
    {
        public static List<Users> Users = new List<Users>
        {
            new Users {Id = 1, Name = "Murat", Password = "123456",Role="Admin"},
            new Users {Id = 2, Name = "Metin", Password = "123456",Role="Pleb"},
        };
    }
}

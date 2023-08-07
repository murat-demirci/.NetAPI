namespace JwtMiddlevare.API.Models
{
    public class Tokenresponse
    {
        public string? AccesToken { get; set; }
        public string? TokenType { get; set; } = "Bearer";
        public DateTime ExpiresAt { get; set; }
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
    }
}

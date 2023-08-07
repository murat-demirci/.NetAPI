using System.Security.Claims;
using System.Text;

namespace MiddlewareAuthenticationSample.API.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //"Basic {base64 kullanici adi ve sifre}"
            string authHeader = context.Request.Headers.Authorization;
            try
            {
                if (authHeader is not null && authHeader.StartsWith("basic", StringComparison.OrdinalIgnoreCase))
                {
                    //Kullanici adi ve Sifre kismini al
                    var token = authHeader.Substring(6).Trim();
                    //stringe cevir
                    var credentialString = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                    var credentials = credentialString.Split(":");
                    if (credentials[0].Equals("murat") && credentials[1].Equals("123"))
                    {
                        var calims = new[]
                        {
                            new Claim("name",credentials[0]),
                            new Claim(ClaimTypes.Role,"Admin")
                        };
                        var identity = new ClaimsIdentity(calims, "Basic");
                        context.User = new ClaimsPrincipal(identity);

                    }
                    else
                    {
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    }
                }
                else
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                }
            }
            catch
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            await _next(context);
        }
    }
}

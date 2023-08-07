namespace MiddlewareAuthenticationSample.API.Middleware.Extensions
{
    public static class AuthenticationMiddlewareExtenison
    {
        public static IApplicationBuilder UseAuthenticateMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}

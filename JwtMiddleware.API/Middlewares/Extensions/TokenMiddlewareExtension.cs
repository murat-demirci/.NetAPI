namespace JwtMiddleware.API.Middlewares.Extensions
{
    public static class TokenMiddlewareExtension
    {
        public static IApplicationBuilder UseTokenMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenMiddleware>();
        }
    }
}

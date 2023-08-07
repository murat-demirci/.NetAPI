namespace MiddlewareSample.API.Middlewares.Extensions
{
    public static class LogMiddlewareExtension
    {
        public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogMiddleware>();
        }
    }
}

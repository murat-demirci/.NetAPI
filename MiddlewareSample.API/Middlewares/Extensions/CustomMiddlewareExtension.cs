namespace MiddlewareSample.API.Middlewares.Extensions
{
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseCustom(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomMiddleware>();
        }
    }
}

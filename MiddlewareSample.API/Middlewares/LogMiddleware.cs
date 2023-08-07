namespace MiddlewareSample.API.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            finally
            {
                var connection = $"{context.Connection.RemoteIpAddress} | {context.Connection.RemotePort} => {context.Connection.LocalIpAddress} | {context.Connection.LocalPort}{Environment.NewLine}";
                var directory = Directory.GetCurrentDirectory();
                var path = Path.Combine(directory, "Middlewares", "log.txt");

                await File.AppendAllTextAsync(path, connection);
            }
        }
    }
}

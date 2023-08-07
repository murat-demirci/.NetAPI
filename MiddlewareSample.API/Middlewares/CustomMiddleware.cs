namespace MiddlewareSample.API.Middlewares
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string logText = string.Empty;
            try
            {
                var cookies = new CookieOptions
                {
                    Path = "/",
                    Expires = DateTimeOffset.UtcNow.AddHours(1),
                    IsEssential = true,
                    HttpOnly = false,
                    Secure = false,
                };

                context.Response.Cookies.Append("MyCookie", "TheValue", cookies);
                logText = $"REQUEST\nMethod: {context.Request?.Method}\nPath:{context.Request?.Path.Value}\nBody: \n";
                //context.Request.Cookies.ToList().ForEach(cookie => logText += $"{cookie.Key}: {cookie.Value}");
            }
            finally
            {
                await _next(context);
                logText += ($"RESPONSE\nStatusCode: {context.Response?.StatusCode}\nHeaders:");
                context.Response.Headers.ToList().ForEach(x => logText += $"{x.Key}: {x.Value}");
                logText += $"\nCookies: {context.Request.Cookies.First().Key}: {context.Request.Cookies.First().Value}";
                var directory = Directory.GetCurrentDirectory();
                var path = Path.Combine(directory, "Middlewares", "log.txt");

                await File.AppendAllTextAsync(path, logText);
            }
        }
    }
}

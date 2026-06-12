namespace LeaveManagementAPI.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine(
                $"URL: {context.Request.Path} Time: {DateTime.Now}");

            await _next(context);

            Console.WriteLine(
                $"Status Code: {context.Response.StatusCode}");
        }
    }
}
namespace DemoWebAPI.Autentication;
using  DemoWebAPI.Constants;
public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public AuthenticationMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }
    public async Task InvokeAsync(HttpContext context)
    {
      var value = context.Request.Headers.TryGetValue(AuthConstants.HeaderName, out var extractedApiKey);
      if(!value)
      {
          context.Response.StatusCode = 401;
          await context.Response.WriteAsync("Api Key is missing");
          return;
      }
      var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKey);
        if(!apiKey.Equals(extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }
        await _next(context);
    }
}
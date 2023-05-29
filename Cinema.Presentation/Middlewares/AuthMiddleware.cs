using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Cinema.Presentation.Middlewares;

public class AuthMiddleware : IMiddleware
{
    private readonly HttpClient httpClient;
    private readonly string identityServerBaseUrl;

    public AuthMiddleware(IHttpClientFactory httpClientFactory)
    {
        httpClient = httpClientFactory.CreateClient();
        identityServerBaseUrl = "https://localhost:7180";
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.GetEndpoint()?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
        {
            await next(context);
            return;
        }

        // Validate the token
        var jwtToken = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
        var response = await httpClient.PostAsync($"{identityServerBaseUrl}/api/identity/validate", null);

        if (!response.IsSuccessStatusCode)
        {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            return;
        }

        // Extract the user role from the JWT
        var jwtPayload = jwtToken.Split('.')[1];
        var decodedJwtPayload = Encoding.UTF8.GetString(Base64UrlDecode(jwtPayload));
        var jsonPayload = JsonSerializer.Deserialize<Dictionary<string, object>>(decodedJwtPayload);
        var role = jsonPayload.ContainsKey("role") ? jsonPayload["role"].ToString() : "";

        // Add the role claim to the identity
        var identity = new ClaimsIdentity(context.User.Identity);
        identity.AddClaim(new Claim(ClaimTypes.Role, role));
        context.User = new ClaimsPrincipal(identity);

        await next(context);
    }

    private static byte[] Base64UrlDecode(string input)
    {
        var base64 = input.Replace('-', '+').Replace('_', '/');
        return Convert.FromBase64String(base64.PadRight(base64.Length + (4 - base64.Length % 4) % 4, '='));
    }
}

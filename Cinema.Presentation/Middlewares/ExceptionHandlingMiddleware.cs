using Cinema.Application.Common.Movies.Exceptions;
using Cinema.Application.Common.Projections.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Presentation.Middlewares;

public class ExceptionHandlingMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (MovieNotFoundException movieNotFoundException)
        {
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status404NotFound,
                Type = "Application Layer error",
                Title = "MovieNotFoundException",
                Detail = movieNotFoundException.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }

        catch(ProjectionIsSoldException projectionIsSoldException)
        {
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status500InternalServerError,
                Type = "Domain Layer error",
                Title = "ProjectionIsSoldException",
                Detail = projectionIsSoldException.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
    }
}

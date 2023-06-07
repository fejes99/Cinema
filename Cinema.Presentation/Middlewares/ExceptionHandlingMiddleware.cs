using Cinema.Application.Abstractions;
using Cinema.Application.Common.Auth.Exceptions;
using Cinema.Application.Common.Projections.Exceptions;
using Cinema.Domain.AggregateModels.Movies.Exceptions;
using Cinema.Domain.AggregateModels.Projections.Exceptions;
using Cinema.Domain.AggregateModels.Users.Exceptions;
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
        catch (NotFoundException exception)
        {
            context.Response.StatusCode = StatusCodes.Status404NotFound;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status404NotFound,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (MovieDurationRangeException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (MovieYearRangeException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (ProjectionPriceRangeException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (ProjectionTimeRangeException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (ProjectionTimeOverlapException exception)
        {
            context.Response.StatusCode = StatusCodes.Status409Conflict;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (ProjectionIsSoldException exception)
        {
            context.Response.StatusCode = StatusCodes.Status409Conflict;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status409Conflict,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (UserAlreadyExistsException exception)
        {
            context.Response.StatusCode = StatusCodes.Status409Conflict;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status409Conflict,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (UsernameRegexException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (PasswordRegexException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
        catch (InvalidPasswordException exception)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            ProblemDetails details = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "Server error",
                Title = exception.GetType().ToString(),
                Detail = exception.Message
            };

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(details);
        }
    }
}

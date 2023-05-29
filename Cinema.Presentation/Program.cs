using Cinema.Application.Common.Auth.UseCases;
using Cinema.Application.Common.Auth.UseCases.Impl;
using Cinema.Application.Common.Movies.UseCases;
using Cinema.Application.Common.Movies.UseCases.Impl;
using Cinema.Application.Common.Projections.ProjectionTypes.UseCases;
using Cinema.Application.Common.Projections.ProjectionTypes.UseCases.Impl;
using Cinema.Application.Common.Projections.UseCases;
using Cinema.Application.Common.Projections.UseCases.Impl;
using Cinema.Application.Common.Theaters.UseCases;
using Cinema.Application.Common.Theaters.UseCases.Impl;
using Cinema.Application.Common.Tickets.UseCases;
using Cinema.Application.Common.Tickets.UseCases.Impl;
using Cinema.Application.Common.Users.UseCases;
using Cinema.Application.Common.Users.UseCases.Impl;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Users;
using Cinema.Infrastructure;
using Cinema.Infrastructure.Common.Movies.Repositories;
using Cinema.Infrastructure.Common.Projections.Repositories;
using Cinema.Infrastructure.Common.Theaters.Repositories;
using Cinema.Infrastructure.Common.Tickets.Repositories;
using Cinema.Infrastructure.Common.Users.Repositories;
using Cinema.Presentation.Middlewares;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Cinema API",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter JWT Token in the form: Bearer [token]"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddHttpClient();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source=../Cinema.Infrastructure/Projection.db"));

builder.Services.AddTransient<ExceptionHandlingMiddleware>();
builder.Services.AddTransient<AuthMiddleware>();

builder.Services.AddScoped<IAuthUseCase, AuthUseCase>();

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieUseCase, MovieUseCase>();

builder.Services.AddScoped<IProjectionTypeRepository, ProjectionTypeRepository>();
builder.Services.AddScoped<IProjectionTypeUseCase, ProjectionTypeUseCase>();

builder.Services.AddScoped<ITheaterRepository, TheaterRepository>();
builder.Services.AddScoped<ITheaterUseCase, TheaterUseCase>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserUseCase, UserUseCase>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketUseCase, TicketUseCase>();

builder.Services.AddScoped<IProjectionRepository, ProjectionRepository>();
builder.Services.AddScoped<IProjectionUseCase, ProjectionUseCase>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the app
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseMiddleware<AuthMiddleware>();

app.MapControllers();

app.Run();

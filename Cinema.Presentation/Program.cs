using Cinema.Application.Common.Movies.UseCases;
using Cinema.Application.Common.Movies.UseCases.Impl;
using Cinema.Application.Common.Projections.UseCases;
using Cinema.Application.Common.Projections.UseCases.Impl;
using Cinema.Application.Common.Theaters.ProjectionTypes.UseCases;
using Cinema.Application.Common.Theaters.ProjectionTypes.UseCases.Impl;
using Cinema.Application.Common.Theaters.Theaters.UseCases;
using Cinema.Application.Common.Theaters.Theaters.UseCases.Impl;
using Cinema.Application.Common.Tickets.UseCases;
using Cinema.Application.Common.Tickets.UseCases.Impl;
using Cinema.Application.Common.Users.UseCases;
using Cinema.Application.Common.Users.UseCases.Impl;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source=../Cinema.Infrastructure/Projection.db"));

builder.Services.AddTransient<ExceptionHandlingMiddleware>();

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieUseCase, MovieUseCase>();

builder.Services.AddScoped<IProjectionTypeRepository, ProjectionTypeRepository>();
builder.Services.AddScoped<IProjectionTypeUseCase, ProjectionTypeUseCase>();

builder.Services.AddScoped<ITheaterRepository, TheaterRepository>();
builder.Services.AddScoped<ITheaterUseCase, TheaterUseCase>();

builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserUseCase, UserUseCase>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketUseCase, TicketUseCase>();

builder.Services.AddScoped<IProjectionRepository, ProjectionRepository>();
builder.Services.AddScoped<IProjectionUseCase, ProjectionUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();

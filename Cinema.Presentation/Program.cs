using Cinema.Application.Common.Movies.UseCases;
using Cinema.Application.Common.Movies.UseCases.Impl;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Infrastructure;
using Cinema.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In Cinema.Presentation Program.cs

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source=../Cinema.Infrastructure/Projection.db"));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IGetMoviesUseCase, GetMoviesUseCase>();
builder.Services.AddScoped<IGetMovieByIdUseCase, GetMovieByIdUseCase>();

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

app.MapControllers();

app.Run();

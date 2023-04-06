using Cinema.Domain.AggregateModels.Movies;
using Cinema.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite("Data Source=Projection.db"));

var app = builder.Build();
app.Run();
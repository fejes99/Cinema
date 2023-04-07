using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Movies.Configurations;

internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(movie => movie.Id);

        builder.Property(movie => movie.Id).HasConversion(
            movieId => movieId.Value,
            value => new MovieId(value));

        builder.Property(movie => movie.Name).HasConversion(
            movieName => movieName.Value,
            value => new MovieName(value));

        builder.Property(movie => movie.Director).HasConversion(
            movieDirector => movieDirector!.Value,
            value => MovieDirector.Create(value));

        builder.Property(movie => movie.Duration).HasConversion(
            movieDuration => movieDuration.Value,
            value => MovieDuration.Create(value));

        builder.Property(movie => movie.Distributor).HasConversion(
            movieDistributor => movieDistributor.Value,
            value => new MovieDistributor(value));

        builder.Property(movie => movie.Country).HasConversion(
            movieCountry => movieCountry.Value,
            value => new MovieCountry(value));

        builder.Property(movie => movie.Year).HasConversion(
            movieYear => movieYear.Value,
            value => MovieYear.Create(value));

        builder.Property(movie => movie.Description).HasConversion(
            movieDescription => movieDescription!.Value,
            value => MovieDescription.Create(value));

        //builder.Property(m => m.Description).HasMaxLength(255);
    }
}

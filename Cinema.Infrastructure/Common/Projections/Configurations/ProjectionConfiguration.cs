using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Projections.Configurations;

internal class ProjectionConfiguration : IEntityTypeConfiguration<Projection>
{
    public void Configure(EntityTypeBuilder<Projection> builder)
    {
        builder.HasKey(projection => projection.Id);

        builder.Property(projection => projection.Id).HasConversion(
            projectionId => projectionId.Value,
            value => new ProjectionId(value));

        builder.Property(projection => projection.Time).HasConversion(
            projectionTime => projectionTime.Value,
            value => ProjectionTime.CreateWithValue(value));

        builder.Property(projection => projection.Price).HasConversion(
            projectionPrice => projectionPrice.Value,
            value => ProjectionPrice.Create(value));

        builder.Property(projection => projection.MovieId).HasConversion(
            projectionMovieId => projectionMovieId.Value,
            value => new MovieId(value));

        builder.Property(projection => projection.ProjectionTypeId).HasConversion(
            projectionProjectionTypeId => projectionProjectionTypeId.Value,
            value => new ProjectionTypeId(value));

        builder.Property(projection => projection.TheaterId).HasConversion(
            projectionTheaterId => projectionTheaterId.Value,
            value => new TheaterId(value));
    }
}

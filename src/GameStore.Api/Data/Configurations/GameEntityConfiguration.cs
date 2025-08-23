using GameStore.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Api.Data.Configurations;

public class GameEntityConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.Property(Game => Game.Name)
               .HasMaxLength(50);

        builder.Property(Game => Game.Description)
               .HasMaxLength(500);

        // 1.00 - 100.00
        builder.Property(game => game.Price)
               .HasPrecision(5, 2);
    }
}

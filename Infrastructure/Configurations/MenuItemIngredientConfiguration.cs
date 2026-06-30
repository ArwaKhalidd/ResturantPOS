using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class MenuItemIngredientConfiguration : IEntityTypeConfiguration<MenuItemIngredient>
{
    public void Configure(EntityTypeBuilder<MenuItemIngredient> builder)
    {
        builder.ToTable("MenuItemIngredients");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.QuantityUsed)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.HasOne(x => x.MenuItem)
            .WithMany(x => x.MenuItemIngredients)
            .HasForeignKey(x => x.MenuItemId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Ingredient)
            .WithMany(x => x.MenuItemIngredients)
            .HasForeignKey(x => x.IngredientId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.MenuItemId);

        builder.HasIndex(x => x.IngredientId);

        builder.HasIndex(x => new { x.MenuItemId, x.IngredientId })
            .IsUnique();
    }
}
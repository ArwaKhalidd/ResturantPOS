using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.ToTable("MenuItems");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Price)
            .HasPrecision(18, 2);

        builder.Property(x => x.IsAvailable)
            .HasDefaultValue(true);

        builder.Property(x => x.IsSeasonalItem)
            .HasDefaultValue(false);

        builder.Property(x => x.CreatedAt)
            .HasDefaultValueSql("GETDATE()");

        builder.HasOne(x => x.Category)
            .WithMany(x => x.MenuItems)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.OrderItems)
            .WithOne(x => x.MenuItem)
            .HasForeignKey(x => x.MenuItemId);

        builder.HasMany(x => x.MenuItemIngredients)
            .WithOne(x => x.MenuItem)
            .HasForeignKey(x => x.MenuItemId);
    }
}
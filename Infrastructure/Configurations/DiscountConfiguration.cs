using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("Discounts");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.DiscountPercent)
            .HasPrecision(5, 2);

        builder.Property(x => x.DiscountAmount)
            .HasPrecision(18, 2);

        builder.Property(x => x.Reason)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.AppliedAt);

        builder.HasOne(x => x.Order)
            .WithMany(x => x.Discounts)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.ApprovedByEmployee)
            .WithMany(x => x.Discounts)
            .HasForeignKey(x => x.ApprovedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.OrderId);

        builder.HasIndex(x => x.ApprovedBy);
    }
}
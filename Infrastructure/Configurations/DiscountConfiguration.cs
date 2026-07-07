using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("Discounts");

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
            .ValueGeneratedOnAdd();

        builder.Property(d => d.DiscountPercent)
            .HasPrecision(5, 2);

        builder.Property(d => d.DiscountAmount)
            .HasPrecision(18, 2);

        builder.Property(d => d.Reason)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(d => d.AppliedAt);

        builder.HasOne(d => d.Order)
            .WithMany(o => o.Discounts)
            .HasForeignKey(d => d.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(d => d.ApprovedByEmployee)
            .WithMany(e => e.Discounts)
            .HasForeignKey(d => d.ApprovedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(d => d.OrderId);

        builder.HasIndex(d => d.ApprovedBy);
    }
}
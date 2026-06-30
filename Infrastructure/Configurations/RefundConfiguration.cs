using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class RefundConfiguration : IEntityTypeConfiguration<Refund>
{
    public void Configure(EntityTypeBuilder<Refund> builder)
    {
        builder.ToTable("Refunds");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Amount)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.RefundType)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.RefundDetail)
            .HasMaxLength(500);

        builder.Property(x => x.RefundedAt);

        builder.HasOne(x => x.Payment)
            .WithMany(x => x.Refunds)
            .HasForeignKey(x => x.PaymentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.ApprovedByEmployee)
            .WithMany(x => x.Refunds)
            .HasForeignKey(x => x.ApprovedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.PaymentId);

        builder.HasIndex(x => x.ApprovedBy);
    }
}
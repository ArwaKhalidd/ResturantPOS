using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Table)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.TableId);

        builder.HasOne(x => x.Waiter)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.WaiterId);
    }
}
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class TableTransferLogConfiguration : IEntityTypeConfiguration<TableTransferLog>
{
    public void Configure(EntityTypeBuilder<TableTransferLog> builder)
    {
        builder.ToTable("TableTransferLog");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.TransferType)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.TransferDetail)
            .HasMaxLength(500);

        builder.Property(x => x.TransferredAt)
            .HasDefaultValueSql("GETDATE()");

        builder.HasOne(x => x.Order)
            .WithMany(x => x.TableTransferLog)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.FromTable)
            .WithMany(x => x.IncomingTransfers)
            .HasForeignKey(x => x.FromTableId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ToTable)
            .WithMany(x => x.OutgoingTransfers)
            .HasForeignKey(x => x.ToTableId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.TransferredByEmployee)
            .WithMany(x => x.TableTransferLogs)
            .HasForeignKey(x => x.TransferredBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(x => x.OrderId);

        builder.HasIndex(x => x.FromTableId);

        builder.HasIndex(x => x.ToTableId);

        builder.HasIndex(x => x.TransferredBy);
    }
}
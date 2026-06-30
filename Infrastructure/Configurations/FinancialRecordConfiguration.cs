using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class FinancialRecordConfiguration : IEntityTypeConfiguration<FinancialRecord>
{
    public void Configure(EntityTypeBuilder<FinancialRecord> builder)
    {
        builder.ToTable("FinancialRecords");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Type)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(x => x.Amount)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(500);

        builder.Property(x => x.RecordDate)
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasDefaultValueSql("GETDATE()");

        builder.HasIndex(x => x.RecordDate);

        builder.HasIndex(x => x.Type);
    }
}
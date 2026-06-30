using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
{
    public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
    {
        builder.ToTable("EmployeeAttendance");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.WorkDate)
            .IsRequired();

        builder.Property(x => x.CheckIn)
            .IsRequired();

        builder.Property(x => x.CheckOut);

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.EmployeeAttendances)
            .HasForeignKey(x => x.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.EmployeeId);

        builder.HasIndex(x => new { x.EmployeeId, x.WorkDate })
            .IsUnique();
    }
}
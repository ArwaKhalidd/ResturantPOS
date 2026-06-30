using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class EmployeeAttendance
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime? CheckOut { get; set; }
    public DateTime? WorkDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
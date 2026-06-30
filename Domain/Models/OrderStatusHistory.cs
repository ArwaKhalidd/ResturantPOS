using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class OrderStatusHistory
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string OldStatus { get; set; } = null!;
    public string NewStatus { get; set; } = null!;
    public int? ChangedBy { get; set; }
    public DateTime? ChangedAt { get; set; }

    public virtual Order Order { get; set; } = null!;
    public virtual Employee? ChangedByEmployee { get; set; }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int MenuItemId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Notes { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
    public virtual MenuItem MenuItem { get; set; } = null!;
}
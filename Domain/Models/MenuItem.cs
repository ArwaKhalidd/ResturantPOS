using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int? CategoryId { get; set; }
    public bool? IsAvailable { get; set; }
    public bool? IsSeasonalItem { get; set; }
    public DateTime? CreatedAt { get; set; }

    public virtual Category? Category { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public virtual ICollection<MenuItemIngredient> MenuItemIngredients { get; set; } = new List<MenuItemIngredient>();
}
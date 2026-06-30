using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class MenuItemIngredient
{
    public int Id { get; set; }
    public int MenuItemId { get; set; }
    public int IngredientId { get; set; }
    public decimal QuantityUsed { get; set; }

    public virtual MenuItem MenuItem { get; set; } = null!;
    public virtual Ingredient Ingredient { get; set; } = null!;
}

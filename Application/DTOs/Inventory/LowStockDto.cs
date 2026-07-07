namespace Application.DTOs.Inventory;

public class LowStockDto
{
    public int IngredientId { get; set; }

    public string IngredientName { get; set; } = string.Empty;

    public decimal CurrentQuantity { get; set; }

    public decimal MinimumStockLevel { get; set; }
}
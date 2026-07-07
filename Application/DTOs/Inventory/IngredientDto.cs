namespace Application.DTOs.Inventory;

public class IngredientDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Quantity { get; set; }

    public string Unit { get; set; } = string.Empty;

    public decimal MinimumStockLevel { get; set; }

    public bool IsLowStock { get; set; }
}
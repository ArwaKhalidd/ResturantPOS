namespace Application.DTOs.Inventory;

public class CreateIngredientDto
{
    public string Name { get; set; } = string.Empty;

    public decimal Quantity { get; set; }

    public string Unit { get; set; } = string.Empty;

    public decimal MinimumStockLevel { get; set; }
}
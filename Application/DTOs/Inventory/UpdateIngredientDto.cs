namespace Application.DTOs.Inventory;

public class UpdateIngredientDto
{
    public string Name { get; set; } = string.Empty;

    public string Unit { get; set; } = string.Empty;

    public decimal MinimumStockLevel { get; set; }
}
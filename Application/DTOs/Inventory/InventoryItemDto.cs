namespace Application.DTOs.Inventory;

public class InventoryItemDto
{
    public int Id { get; set; }

    public string IngredientName { get; set; } = string.Empty;

    public decimal Quantity { get; set; }

    public string Unit { get; set; } = string.Empty;

    public DateTime LastUpdated { get; set; }
}
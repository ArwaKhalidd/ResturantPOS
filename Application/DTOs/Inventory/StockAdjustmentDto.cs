using Domain.Enums;

namespace Application.DTOs.Inventory;

public class StockAdjustmentDto
{
    public int IngredientId { get; set; }

    public decimal Quantity { get; set; }

    public InventoryReasonType Type { get; set; }

    public string? Reason { get; set; }
}
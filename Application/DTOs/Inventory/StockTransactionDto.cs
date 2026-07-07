using Domain.Enums;
namespace Application.DTOs.Inventory;

public class StockTransactionDto
{
    public int IngredientId { get; set; }

    public string IngredientName { get; set; } = string.Empty;

    public decimal Quantity { get; set; }

    public InventoryReasonType ReasonType { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? ReasonDetail { get; set; }
}
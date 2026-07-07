namespace Application.DTOs.Orders;

public class OrderItemDto
{
    public int MenuItemId { get; set; }

    public string MenuItemName { get; set; } = string.Empty;

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Notes { get; set; }
}
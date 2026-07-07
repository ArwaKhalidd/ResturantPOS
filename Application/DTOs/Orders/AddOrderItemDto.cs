namespace Application.DTOs.Orders;

public class AddOrderItemDto
{
    public int MenuItemId { get; set; }

    public int Quantity { get; set; }

    public string? Notes { get; set; }
}
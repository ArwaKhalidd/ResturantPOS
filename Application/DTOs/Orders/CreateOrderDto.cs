namespace Application.DTOs.Orders;

public class CreateOrderDto
{
    public int TableId { get; set; }

    public List<AddOrderItemDto> Items { get; set; } = [];
}
namespace Application.DTOs.Orders;

public class UpdateOrderDto
{
    public List<AddOrderItemDto> Items { get; set; } = [];
}
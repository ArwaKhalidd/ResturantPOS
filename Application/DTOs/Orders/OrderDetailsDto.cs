using Domain.Enums;
namespace Application.DTOs.Orders;

public class OrderDetailsDto
{
    public int Id { get; set; }

    public int TableId { get; set; }

    public string WaiterName { get; set; } = string.Empty;

    public OrderStatus Status { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<OrderItemDto> Items { get; set; } = [];
}
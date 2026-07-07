using Domain.Enums;
namespace Application.DTOs.Orders;

public class OrderResponseDto
{
    public int Id { get; set; }

    public int TableId { get; set; }

    public OrderStatus Status { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }
}
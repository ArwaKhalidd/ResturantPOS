using Domain.Enums;
using Application.DTOs.Orders;
namespace Application.DTOs.Payments;

public class InvoiceDto
{
    public int OrderId { get; set; }

    public int TableNumber { get; set; }

    public string WaiterName { get; set; } = string.Empty;

    public List<OrderItemDto> Items { get; set; } = new();

    public decimal SubTotal { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal FinalAmount { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public DateTime PaidAt { get; set; }
}
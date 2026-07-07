using Domain.Enums;
namespace Application.DTOs.Orders;

public class PayOrderDto
{
    public PaymentMethod PaymentMethod { get; set; }

    public decimal PaidAmount { get; set; }
}
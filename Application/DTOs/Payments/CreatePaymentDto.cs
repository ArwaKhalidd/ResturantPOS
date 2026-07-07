using Domain.Enums;

namespace Application.DTOs.Payments;

public class CreatePaymentDto
{
    public int OrderId { get; set; }

    public decimal AmountPaid { get; set; }

    public PaymentMethod PaymentMethod { get; set; }
}
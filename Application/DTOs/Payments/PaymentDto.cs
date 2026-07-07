using Domain.Enums;

namespace Application.DTOs.Payments;

public class PaymentDto
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public decimal AmountPaid { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public DateTime PaidAt { get; set; }
}
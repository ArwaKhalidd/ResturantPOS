using Domain.Enums;

namespace Application.DTOs.Payments;

public class PaymentFilterDto
{
    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public PaymentMethod? PaymentMethod { get; set; }
}
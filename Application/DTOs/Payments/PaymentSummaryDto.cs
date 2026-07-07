namespace Application.DTOs.Payments;

public class PaymentSummaryDto
{
    public decimal TotalRevenue { get; set; }

    public int TotalTransactions { get; set; }

    public decimal AveragePayment { get; set; }
}
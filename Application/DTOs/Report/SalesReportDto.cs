namespace Application.DTOs.Reports;

public class SalesReportDto
{
    public decimal TotalSales { get; set; }

    public int TotalOrders { get; set; }

    public decimal AverageOrderValue { get; set; }

    public List<TopSellingItemDto> TopSellingItems { get; set; } = new();
}
namespace Application.DTOs.Reports;

public class TopSellingItemDto
{
    public string ItemName { get; set; } = string.Empty;

    public int QuantitySold { get; set; }
}
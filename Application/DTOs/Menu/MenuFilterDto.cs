namespace Application.DTOs.Menu;

public class MenuFilterDto
{
    public int? CategoryId { get; set; }

    public string? Search { get; set; }

    public bool? AvailableOnly { get; set; }
}
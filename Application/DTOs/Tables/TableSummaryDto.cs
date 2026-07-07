namespace Application.DTOs.Tables;

public class TableSummaryDto
{
    public int TotalTables { get; set; }

    public int AvailableTables { get; set; }

    public int OccupiedTables { get; set; }

    public int ReservedTables { get; set; }
}
using Application.DTOs.Tables;

namespace Application.Services.Interfaces;

public interface ITableService
{
    Task<TableResponseDto> CreateTableAsync(CreateTableDto dto);
    Task<TableResponseDto> GetTableByIdAsync(int id);
    Task<IEnumerable<TableSummaryDto>> GetAllTablesAsync();
    Task<TableResponseDto> UpdateTableAsync(int id, UpdateTableDto dto);
    Task<TableResponseDto> UpdateTableStatusAsync(int id, UpdateTableStatusDto dto);
    Task<bool> DeleteTableAsync(int id);
}

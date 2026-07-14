using Application.DTOs.Orders;

namespace Application.Services.Interfaces;

public interface IOrderService
{
    Task<OrderResponseDto> CreateOrderAsync(CreateOrderDto dto, int waiterId);
    Task<OrderDetailsDto> GetOrderByIdAsync(int id);
    Task<IEnumerable<OrderSummaryDto>> GetAllOrdersAsync();
    Task<OrderResponseDto> UpdateOrderAsync(int id, UpdateOrderDto dto);
    Task<OrderResponseDto> UpdateOrderStatusAsync(int id, UpdateOrderStatusDto dto);
    Task<OrderResponseDto> AddOrderItemAsync(int orderId, AddOrderItemDto dto);
    Task<bool> RemoveOrderItemAsync(int orderId, RemoveOrderItemDto dto);
    Task<bool> PayOrderAsync(int orderId, PayOrderDto dto);
}

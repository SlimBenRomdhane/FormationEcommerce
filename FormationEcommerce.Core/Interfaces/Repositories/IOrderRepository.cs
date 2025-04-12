using FormationEcommerce.Core.Entities.Orders;
using FormationEcommerce.Core.Interfaces.Repositories.Base;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface IOrderRepository : IRepository<OrderHeader>
    {
        Task<OrderHeader> AddOrderHeaderAsync(OrderHeader orderHeader);

        Task<OrderDetail> AddOrderDetailAsync(OrderDetail orderDetail);

        Task<IEnumerable<OrderHeader>> GetAllOrderHeadersAsync();

        Task<IEnumerable<OrderHeader>> GetAllOrderHeadersByUserIdAsync(string userId);

        Task<OrderHeader?> GetOrderHeaderByIdAsync(Guid orderHeaderId);

        Task<string> UpdateStatusAsync(Guid orderHeaderId, string newStatus);

        Task<OrderHeader?> UpdateOrderHeaderAsync(OrderHeader orderHeader);
    }
}
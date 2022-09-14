using Cheese.Services.OrderAPI.Models;

namespace Cheese.Services.OrderAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader orderHeader);
        Task UpdateOrderByPaymentStatus(int orderHeaderId, bool paid);
    }
}

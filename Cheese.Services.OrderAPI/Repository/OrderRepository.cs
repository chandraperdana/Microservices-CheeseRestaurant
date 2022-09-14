using Cheese.Services.OrderAPI.DbContexts;
using Cheese.Services.OrderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Cheese.Services.OrderAPI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> dbContext;

        public OrderRepository(DbContextOptions<ApplicationDbContext> dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AddOrder(OrderHeader orderHeader)
        {
            await using var db = new ApplicationDbContext(dbContext);
            db.OrderHeaders.Add(orderHeader);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task UpdateOrderByPaymentStatus(int orderHeaderId, bool paid)
        {
            await using var db = new ApplicationDbContext(dbContext);
            var orderHeaderFromDb = await db.OrderHeaders.FirstOrDefaultAsync(u => u.OrderHeaderId == orderHeaderId);
            if (orderHeaderFromDb != null)
            {
                orderHeaderFromDb.PaymentStatus = paid;
                await db.SaveChangesAsync();
            }
        }
    }
}

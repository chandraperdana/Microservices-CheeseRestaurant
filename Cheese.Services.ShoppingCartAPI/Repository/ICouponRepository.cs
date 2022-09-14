using Cheese.Services.ShoppingCartAPI.Models.Dto;

namespace Cheese.Services.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}

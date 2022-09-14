using Cheese.Services.CouponAPI.Models.Dto;

namespace Cheese.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}

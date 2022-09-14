using AutoMapper;
using Cheese.Services.CouponAPI.DbContexts;
using Cheese.Services.CouponAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cheese.Services.CouponAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CouponRepository(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<CouponDto> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
            return mapper.Map<CouponDto>(couponFromDb);
        }
    }
}

﻿using Cheese.Web.Models;

namespace Cheese.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<T> GetCoupon<T>(string couponCode, string token = null);

    }
}

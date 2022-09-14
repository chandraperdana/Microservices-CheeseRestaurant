using System.ComponentModel.DataAnnotations;

namespace Cheese.Services.ShoppingCartAPI.Models
{
    public class CartHeader
    {
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}

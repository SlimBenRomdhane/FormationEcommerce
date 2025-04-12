using FormationEcommerce.Core.Entities.Coupons;
using FormationEcommerce.Core.Interfaces.Repositories.Base;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface ICouponRepository : IRepository<Coupon>
    {
        Task<Coupon> AddCouponAsync(Coupon coupon);

        Task<Coupon> GetCouponByIdAsync(Guid id);

        Task<Coupon> GetCouponByCodeAsync(string couponCode);

        Task<IEnumerable<Coupon>> GetAllCouponsAsync();

        Task UpdateCouponAsync(Coupon coupon);

        Task DeleteCouponAsync(Guid couponId);
    }
}
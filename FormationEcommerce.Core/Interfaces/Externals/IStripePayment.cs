using FormationEcommerce.Core.Entities.Orders;

namespace FormationEcommerce.Core.Interfaces.Externals
{
    public interface IStripePayment
    {
        Task<(string SessionId, string SessionUrl)> CreateCheckOutSession(OrderHeader orderHeader, string approvedUrl, string cancelUrl);

        Task<(string Status, string? PaymentIntentId)> ValidatePaymentSession(string sessionId);

        Task<string> CreateCoupon(string couponCode, string discountAmout);

        Task<string> DeleteCoupon(string couponCode);

        Task<bool> ProcessRefund(string paymentIntentId);
    }
}
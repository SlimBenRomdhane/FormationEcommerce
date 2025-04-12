using FormationEcommerce.Core.Entities.Carts;
using FormationEcommerce.Core.Interfaces.Repositories.Base;

namespace FormationEcommerce.Core.Interfaces.Repositories
{
    public interface ICartRepository : IRepository<CartHeader>
    {
        //Why nullable result ?
        Task<CartHeader?> GetCartByUserIdAsync(string userId);

        Task<IEnumerable<CartDetail>> GetListCartDetailsByCartHeaderIdAsync(Guid cartHeaderId);

        /*Isn't this CRUD, why duplication*/

        Task<CartHeader> AddCartHeaderAsync(CartHeader cartHeader);

        /*Isn't this CRUD, why duplication*/

        Task<CartDetail> AddCartDetailsAsync(CartDetail cartDetail);

        Task<CartDetail?> GetCartDetailsAsyncByCartHeaderIdAndProductId(Guid cartHeaderId, Guid productId);

        Task<CartHeader?> GetCartHeaderByCartHeaderId(Guid cartHeaderId);

        Task<CartDetail?> GetCartDetailsByCartDetailsId(Guid cartDetailId);

        //Why nullable result ?
        Task<CartHeader> UpdateCarHeaderAsync(CartHeader cartHeader);

        //Why nullable result ?
        Task<CartDetail> UpdateCartDetailsAsync(CartDetail cartDetail);

        //Why not boolean result and why would we return a deleted value ?
        Task<CartHeader> DeleteCartHeaderAsync(CartHeader cartHeader);

        //Why not boolean result and why would we return a deleted value ?
        Task<CartDetail> DeleteCartDetailsAsync(CartDetail cartDetail);

        int GetTotalCountOfCartItemsByHeaderId(Guid cartHeaderId);

        Task<bool> ClearCartAsync(string userId);
    }
}
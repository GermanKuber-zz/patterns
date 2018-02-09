using Entities.Interfaces;
using Implementations.Collections;

namespace Implementations.Strategies.Update.RoundAuction
{
    public class
        UpdateProvidersRoundAuctionStrategy : IUpdateStrategy<Entities.Auction, UpdateProvidersRoundAuctionParameters>
    {
        public void Execute(Entities.Auction updatingEntity, UpdateProvidersRoundAuctionParameters parameter)
        {
            updatingEntity.Status = updatingEntity.Status.UpdateProviders(parameter.Providers.Get());
           
        }
    }

    public class UpdateProvidersRoundAuctionParameters : IParameters
    {
        public Providers Providers { get; set; }
        public Entities.Auction AuctionToUpdate { get; }

        public UpdateProvidersRoundAuctionParameters(Providers providers, Entities.Auction auctionToUpdate)
        {
            Providers = providers;
            AuctionToUpdate = auctionToUpdate;
        }
    }
}
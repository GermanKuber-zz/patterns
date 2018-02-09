using System.Collections.Generic;

namespace ConsoleApp3
{

    public class UpdateProvidersRoundAuctionStrategy : IUpdateStrategy<Auction, UpdateProviderParameter>
    {
        public void Execute(Auction updatingEntity, UpdateProviderParameter parameter)
        {
            updatingEntity.Status = updatingEntity.Status.UpdateProviders(parameter.ProvidersToUpdate);
            var UpdateFactoStrategy = new AuctionStrategyFactory();

            var updateProviderStrategy = UpdateFactoStrategy.Make<UpdateProviderParameter>(StrategyTypeEnum.UpdateProvider);
        }

    }

    public class UpdateProvidersRoundAuctionParameters : IParameters
    {
        public List<Provider> ProvidersToUpdate { get; set; }
        public Auction AuctionToUpdate { get; }

        public UpdateProvidersRoundAuctionParameters(List<Provider> providersToUpdate, Auction auctionToUpdate)
        {
            ProvidersToUpdate = providersToUpdate;
            AuctionToUpdate = auctionToUpdate;
        }
    }

   

  
}

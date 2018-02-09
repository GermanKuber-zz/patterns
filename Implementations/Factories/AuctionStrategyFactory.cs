using Entities;
using Entities.Interfaces;
using Implementations.Strategies.Update.Auction;

namespace Implementations.Factories
{
    public class AuctionStrategyFactory : IAuctionFactoryStrategy
    {
        public IUpdateStrategy<Auction,  TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters
        {
            switch (type    )
            {
                case StrategyTypeEnum.UpdateProvider:
                    return (IUpdateStrategy<Auction, TParam>)new UpdateProvidersStrategy();
                case StrategyTypeEnum.AddRound:
                    return (IUpdateStrategy<Auction, TParam>)new AddRoundAuctionStrategy();
                case StrategyTypeEnum.DeleteRound:
                    return (IUpdateStrategy<Auction, TParam>)new DeleteRoundAuctionStrategy();
                case StrategyTypeEnum.CreateBuyer:
                    break;

                default:
                    break;
            }
            return (IUpdateStrategy<Auction, TParam>)new UpdateProvidersStrategy();
        }
    }
}

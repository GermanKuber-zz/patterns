using Entities;
using Entities.Interfaces;
using Implementations.Strategies.Update.RoundAuction;

namespace Implementations.Factories
{
    public class RoundAuctionStrategyFactory : IRoundAuctionStrategyFactory
    {
        public IUpdateStrategy<RoundAuction, TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters
        {
            switch (type)
            {
                case StrategyTypeEnum.UpdateProvider:
                    return (IUpdateStrategy<RoundAuction, TParam>)new UpdateProvidersRoundAuctionStrategy();
                case StrategyTypeEnum.CreateBuyer:
                    break;
                default:
                    break;
            }
            return (IUpdateStrategy<RoundAuction, TParam>)new UpdateProvidersRoundAuctionStrategy();
        }
    }
}

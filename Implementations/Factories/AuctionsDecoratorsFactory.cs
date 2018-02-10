using Entities;
using Entities.Interfaces;
using Implementations.Decorators.Strategies;

namespace Implementations.Factories
{
    public class AuctionsDecoratorsFactory : IAuctionsDecoratorsFactory
    {
        public IDecorator<Auction, TParameters> Make<TParameters>(DecoratorsEnum type) where TParameters : IParameters
        {
            switch (type)
            {
                case DecoratorsEnum.DecoratorAuctionMilestone:
                    return (IDecorator<Auction, TParameters>)new AuctionMilestoneStrategyDecorator();
                default:
                    break;
            }
            return null;
        }
    }
}

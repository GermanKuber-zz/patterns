using Entities;
using Entities.Interfaces;
using Implementations.Decorators.Strategies;

namespace Implementations.Factories
{

    public class AuctionsMilestonesDecoratorsFactory : IAuctionsMilestonesDecoratorsFactory
    {
        public IAuctionDecorator<TParameters> Make<TParameters>(DecoratorsEnum type) where TParameters : IParameters
        {
            switch (type)
            {
                case DecoratorsEnum.AuctionMilestoneUpdateOpeningDate:
                    return (IAuctionDecorator<TParameters>)new AuctionMilestoneUpdateOpeningDecorator();
                case DecoratorsEnum.AuctionMilestoneUpdateProviders:
                    return (IAuctionDecorator<TParameters>)new AuctionMilestoneUpdateProvidersDecorator();
                default:
                    break;
            }
            return null;
        }
    }
}

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
                case DecoratorsEnum.DecoratorAuctionMilestone:
                    return (IAuctionDecorator<TParameters>)new AuctionMilestoneUpdateOpeningDecorator();
                default:
                    break;
            }
            return null;
        }
    }
}

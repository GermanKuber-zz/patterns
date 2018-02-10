using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;

namespace Implementations.Factories
{
    public class AuctionsDecoratorsChainOfResponsibilityFactory : IAuctionsDecoratorsChainOfResponsibilityFactory
    {
        public DecoratorStepAuction<IMilestoneable<Auction>, IMilestoneable<Auction>> Make<TParameters>(AuctionsChainOfResponsibilityEnum type)
        {
            switch (type)
            {
                case AuctionsChainOfResponsibilityEnum.MilestoneOpeningDateStepAction:
                    return new DecoratorAuctionMilestoneOpeningDateStepAction();
                case AuctionsChainOfResponsibilityEnum.MilestoneProvidersStepAction:
                    return new DecoratorAuctionMilestoneProvidersStepAction();
                default:
                    break;
            }
            return new DecoratorAuctionMilestoneOpeningDateStepAction();

        }
    }
}

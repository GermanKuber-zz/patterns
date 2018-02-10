using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;

namespace Implementations.Factories
{
    public class AuctionsMilestoneDecoratorsChainOfResponsibilityFactory : IAuctionsMilestoneDecoratorsChainOfResponsibilityFactory
    {
        public IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> Make<TEntityToProcess, TParameter>(AuctionsChainOfResponsibilityEnum type)
        {
            switch (type)
            {
                case AuctionsChainOfResponsibilityEnum.MilestoneOpeningDateStepAction:
                    return (IDecoratorStepAuctionChainOfResponsibility < TEntityToProcess, TParameter >)new DecoratorAuctionMilestoneOpeningDateStepAction();
                case AuctionsChainOfResponsibilityEnum.MilestoneProvidersStepAction:
                    return (IDecoratorStepAuctionChainOfResponsibility < TEntityToProcess, TParameter >)new DecoratorAuctionMilestoneProvidersStepAction();
                default:
                    break;
            }
            return (IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter>)new DecoratorAuctionMilestoneOpeningDateStepAction();

        }
    }
}

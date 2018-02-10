using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;

namespace Implementations.Factories
{
    public interface IAuctionsMilestoneDecoratorsChainOfResponsibilityFactory
    {
        IDecoratorStepAuctionChainOfResponsibility<TEntityToProcess, TParameter> Make<TEntityToProcess, TParameter>(AuctionsChainOfResponsibilityEnum type);
    }
}
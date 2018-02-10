using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;

namespace Implementations.Factories
{
    public interface IAuctionsDecoratorsChainOfResponsibilityFactory
    {
        DecoratorStepAuction<IMilestoneable<Auction>, IMilestoneable<Auction>> Make<TParameters>(AuctionsChainOfResponsibilityEnum type) where TParameters : IParameters;
    }
}
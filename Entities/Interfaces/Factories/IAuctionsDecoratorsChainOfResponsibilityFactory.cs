using Entities;
using Entities.Interfaces;
using Implementations.ChainOfResponsibility.Decorator;

namespace Implementations.Factories
{
    public interface IAuctionsDecoratorsChainOfResponsibilityFactory
    {
        DecoratorStepAuctionChainOfResponsibility<IMilestoneable<Auction>, IMilestoneable<Auction>> Make(AuctionsChainOfResponsibilityEnum type);
    }
}
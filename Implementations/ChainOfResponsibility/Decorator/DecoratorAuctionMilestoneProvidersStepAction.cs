using Entities;
using Implementations.Strategies.Update.Auction;

namespace Implementations.ChainOfResponsibility.Decorator
{
    public class DecoratorAuctionMilestoneProvidersStepAction : DecoratorStepAuctionChainOfResponsibility<Auction, UpdateOpeningParameter>
    {
        public override void Process(Auction entityToProcess, UpdateOpeningParameter entityPreviousState)
        {
            //TODO: Refactorizar
            //var areEquals = entityToProcess.Providers.CompareTo(entityPreviousState.Providers) == 1;
            //if (areEquals)
            //    entityToProcess.Milestone.PropertyChange(entityToProcess, entityToProcess.Providers, entityPreviousState.Providers);
            successor?.Process(entityToProcess, entityPreviousState);
        }
    }
}

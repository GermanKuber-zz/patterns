using Entities;
using Implementations.Strategies.Update.Auction;

namespace Implementations.ChainOfResponsibility.Decorator
{
    public class DecoratorAuctionMilestoneOpeningDateStepAction : DecoratorStepAuctionChainOfResponsibility<Auction, UpdateOpeningParameter>
    {
        public override void Process(Auction entityToProcess, UpdateOpeningParameter entityPreviousState)
        {
            if (entityToProcess.OpeningDate != entityPreviousState.OpeningDate)
                entityToProcess.Milestone.PropertyChange(entityToProcess, entityToProcess.OpeningDate, entityPreviousState.OpeningDate);
            successor?.Process(entityToProcess, entityPreviousState);
        }
    }
}

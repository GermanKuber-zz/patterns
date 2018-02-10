using Entities;

namespace Implementations.ChainOfResponsibility.Decorator
{
    public class DecoratorAuctionMilestoneOpeningDateStepAction : DecoratorStepAuction<IMilestoneable<Auction>, IMilestoneable<Auction>>
    {
        public override void Process(IMilestoneable<Auction> entityToProcess, IMilestoneable<Auction> entityPreviousState)
        {
            if (entityToProcess.OpeningDate != entityPreviousState.OpeningDate)
                entityToProcess.Milestone.PropertyChange(entityToProcess, entityToProcess.OpeningDate, entityPreviousState.OpeningDate);
            successor.Process(entityToProcess, entityPreviousState);
        }
    }
}

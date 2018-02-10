using Entities;

namespace Implementations.ChainOfResponsibility.Decorator
{
    public class DecoratorAuctionMilestoneProvidersStepAction : DecoratorStepAuction<IMilestoneable<Auction>, IMilestoneable<Auction>>
    {
        public override void Process(IMilestoneable<Auction> entityToProcess, IMilestoneable<Auction> entityPreviousState)
        {
            //TODO: Refactorizar
            var areEquals = entityToProcess.Providers.CompareTo(entityPreviousState.Providers) == 1;
            if (areEquals)
                entityToProcess.Milestone.PropertyChange(entityToProcess, entityToProcess.Providers, entityPreviousState.Providers);
            successor.Process(entityToProcess, entityPreviousState);
        }
    }
}

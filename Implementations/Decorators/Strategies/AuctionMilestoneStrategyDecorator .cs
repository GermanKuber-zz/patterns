using Entities;
using Implementations.Strategies.Update.Auction;

namespace Implementations.Decorators.Strategies
{
    public class AuctionMilestoneUpdateOpeningDecorator : AuctionMilestoneDecoratorBase<UpdateOpeningParameter>
    {
        public override void Execute(Auction updatingEntity, UpdateOpeningParameter parameter)
        {
            Auction previousState = (Auction)updatingEntity.Clone();
            base.Execute(updatingEntity, parameter);

            if (updatingEntity.OpeningDate != previousState.OpeningDate)
                updatingEntity.Milestone.PropertyChange(previousState, updatingEntity.OpeningDate, previousState.OpeningDate);

        }
    }
}

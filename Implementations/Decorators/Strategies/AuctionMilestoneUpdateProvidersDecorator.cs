using Entities;
using Implementations.Strategies.Update.Auction;

namespace Implementations.Decorators.Strategies
{
    public class AuctionMilestoneUpdateProvidersDecorator : AuctionMilestoneDecoratorBase<UpdateProviderParameter>
    {
        public override void Execute(Auction updatingEntity, UpdateProviderParameter parameter)
        {
            Auction previousState = (Auction)updatingEntity.Clone();
            base.Execute(updatingEntity, parameter);

            var areEquals = updatingEntity.Providers.CompareTo(updatingEntity.Providers) == 1;
            if (areEquals)
                updatingEntity.Milestone.PropertyChange(updatingEntity, updatingEntity.Providers, previousState.Providers);

        }
    }
}

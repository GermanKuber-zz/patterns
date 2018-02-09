using Entities.Interfaces;

namespace Implementations.Strategies.Update.Auction
{
    public class DeleteRoundAuctionStrategy : IUpdateStrategy<Entities.Auction, DeleteRoundAuctionParameter>
    {
        public void Execute(Entities.Auction updatingEntity, DeleteRoundAuctionParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus = updatingEntity.RoundAuctionsStatus.DeleteRound(parameter.DeleteRoundAuction);

        }

    }

    public class DeleteRoundAuctionParameter : IParameters
    {
        public Entities.RoundAuction DeleteRoundAuction { get; }

        public DeleteRoundAuctionParameter(Entities.RoundAuction deleteRoundAuction)
        {
            DeleteRoundAuction = deleteRoundAuction;
        }

    }
}

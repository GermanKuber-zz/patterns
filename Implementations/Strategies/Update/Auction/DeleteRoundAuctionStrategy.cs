namespace ConsoleApp3
{
    public class DeleteRoundAuctionStrategy : IUpdateStrategy<Auction, DeleteRoundAuctionParameter>
    {
        public void Execute(Auction updatingEntity, DeleteRoundAuctionParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus = updatingEntity.RoundAuctionsStatus.DeleteRound(parameter.DeleteRoundAuction);

        }

    }

    public class DeleteRoundAuctionParameter : IParameters
    {
        public RoundAuction DeleteRoundAuction { get; }

        public DeleteRoundAuctionParameter(RoundAuction deleteRoundAuction)
        {
            DeleteRoundAuction = deleteRoundAuction;
        }

    }
}

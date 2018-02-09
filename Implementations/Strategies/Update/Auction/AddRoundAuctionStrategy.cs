namespace ConsoleApp3
{
    public class AddRoundAuctionStrategy : IUpdateStrategy<Auction, AddRoundAuctionParameter>
    {
        public void Execute(Auction updatingEntity, AddRoundAuctionParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus = updatingEntity.RoundAuctionsStatus.AddRound(parameter.NewRoundAuction);

        }

    }

    public class AddRoundAuctionParameter : IParameters
    {
        public RoundAuction NewRoundAuction { get; }

        public AddRoundAuctionParameter(RoundAuction newRoundAuction)
        {
            NewRoundAuction = newRoundAuction;
        }

    }
}

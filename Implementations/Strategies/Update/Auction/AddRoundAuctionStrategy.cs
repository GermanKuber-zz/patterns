using Entities.Interfaces;

namespace Implementations.Strategies.Update.Auction
{
    public class AddRoundAuctionStrategy : IUpdateStrategy<Entities.Auction, AddRoundAuctionParameter>
    {
        public void Execute(Entities.Auction updatingEntity, AddRoundAuctionParameter parameter)
        {

            updatingEntity.RoundAuctionsStatus = updatingEntity.RoundAuctionsStatus.AddRound(parameter.NewRoundAuction);

        }

    }

    public class AddRoundAuctionParameter : IParameters
    {
        public Entities.RoundAuction NewRoundAuction { get; }

        public AddRoundAuctionParameter(Entities.RoundAuction newRoundAuction)
        {
            NewRoundAuction = newRoundAuction;
        }

    }
}

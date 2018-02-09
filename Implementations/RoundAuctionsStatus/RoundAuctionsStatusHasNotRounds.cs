using System.Collections.Generic;

namespace ConsoleApp3
{
    public class RoundAuctionsStatusHasNotRounds : RoundAuctionsStatus
    {

        public RoundAuctionsStatusHasNotRounds(Auction auction) : base(auction)
        {
        }

        public override RoundAuctionsStatus AddRound(RoundAuction newRoundAuction) => new RoundAuctionsStatusHasRounds(Auction, newRoundAuction);

        public override RoundAuctionsStatus DeleteRound(RoundAuction roundAuctionToDelete) => this;

        public override void UpdateProviders(List<Provider> providers)
        {
            Auction.Providers = providers;
        }
    }
}

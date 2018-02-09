using System.Collections.Generic;
using Entities;
using Entities.Interfaces.Collections;

namespace Implementations.RoundAuctionsStatus
{
    public class RoundAuctionsStatusHasNotRounds : Entities.RoundAuctionsStatus
    {

        public RoundAuctionsStatusHasNotRounds(Auction auction) : base(auction)
        {
        }

        public override Entities.RoundAuctionsStatus AddRound(RoundAuction newRoundAuction) => new RoundAuctionsStatusHasRounds(Auction, newRoundAuction);

        public override Entities.RoundAuctionsStatus DeleteRound(RoundAuction roundAuctionToDelete) => this;

        public override void UpdateProviders(IProviders providers)
        {
            Auction.Providers = providers.Get();
        }
    }
}

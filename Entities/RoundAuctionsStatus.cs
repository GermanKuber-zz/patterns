using System.Collections.Generic;
using System.Linq;
using Entities.Interfaces.Collections;

namespace Entities
{
    public abstract class RoundAuctionsStatus 
    {
        protected Auction Auction { get; }
        public List<RoundAuction> Rounds { get; protected set; } = new List<RoundAuction>();

        public RoundAuctionsStatus(Auction auction)
        {
            Auction = auction;
        }

        public RoundAuction GetActualRound()
        {
            return Rounds.Last();
        }
        public bool HasRounds() {
            return Rounds.Any();
        }
        public abstract void UpdateProviders(IProviders providers);
        public abstract RoundAuctionsStatus AddRound(RoundAuction newRoundAuction);
        public abstract RoundAuctionsStatus DeleteRound(RoundAuction roundAuctionToDelete);
    }
}

using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
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
        public abstract void UpdateProviders(List<Provider> providers);
        public abstract RoundAuctionsStatus AddRound(RoundAuction newRoundAuction);
        public abstract RoundAuctionsStatus DeleteRound(RoundAuction roundAuctionToDelete);
    }
}

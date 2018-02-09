using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class RoundAuctionsStatusHasRounds : RoundAuctionsStatus
    {
        public RoundAuctionsStatusHasRounds(Auction auction, RoundAuction newRoundAunction) : base(auction)
        {
            AddRound(newRoundAunction);
        }
        public RoundAuctionsStatusHasRounds(Auction auction, List<RoundAuction> newRoundAunctions) : base(auction)
        {
            newRoundAunctions?.Select(x => AddRound(x));
        }

        public override RoundAuctionsStatus AddRound(RoundAuction newRoundAuction)
        {
            if (Rounds == null)
                Rounds = new List<RoundAuction>();

            Rounds.Add(newRoundAuction);

            return this;
        }
        public override RoundAuctionsStatus DeleteRound(RoundAuction roundAuctionToDelete)
        {
            Rounds?.Remove(roundAuctionToDelete);

            if (Rounds == null || Rounds.Count == 0)
                return new RoundAuctionsStatusHasNotRounds(Auction);

            return this;
        }
        public override void UpdateProviders(List<Provider> providers)
        {
            var round = GetActualRound();
            if (round != null)
            {
                //Null Object Pattern
                var roundAuctionStrategyFactory = new RoundAuctionStrategyFactory();
                var updateProviderStrategy = roundAuctionStrategyFactory.Make<UpdateProvidersRoundAuctionParameters>(StrategyTypeEnum.UpdateProvider);
                round.Update(updateProviderStrategy, new UpdateProvidersRoundAuctionParameters(providers, Auction));
            }
        }
    }
}

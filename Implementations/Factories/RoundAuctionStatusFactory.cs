using Entities;
using Entities.Interfaces;
using Implementations.RoundAuctionsStatus;

namespace Implementations.Factories
{
    public class RoundAuctionStatusFactory : IRoundAuctionStatusFactory
    {
        public Entities.RoundAuctionsStatus Make(RoundAuctionStatusTypeEnum type, Auction auction, RoundAuction newRound = null)
        {
            switch (type)
            {
                case RoundAuctionStatusTypeEnum.HasRound:
                    return new RoundAuctionsStatusHasRounds(auction, newRound);
                case RoundAuctionStatusTypeEnum.HasNotRound:
                    return new RoundAuctionsStatusHasNotRounds(auction);

                default:
                    break;
            }
            return new RoundAuctionsStatusHasNotRounds(auction);
        }
    }



}

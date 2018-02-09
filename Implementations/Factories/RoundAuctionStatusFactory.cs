namespace ConsoleApp3
{
    public class RoundAuctionStatusFactory : IRoundAuctionStatusFactory
    {
        public RoundAuctionsStatus Make(RoundAuctionStatusTypeEnum type, Auction auction, RoundAuction newRound = null)
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

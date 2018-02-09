namespace Entities.Interfaces
{
    public interface IRoundAuctionStatusFactory
    {
        RoundAuctionsStatus Make(RoundAuctionStatusTypeEnum type, Auction auction, RoundAuction newRound = null);

    }
}

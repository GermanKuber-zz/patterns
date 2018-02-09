namespace ConsoleApp3
{
    public interface IRoundAuctionStatusFactory
    {
        RoundAuctionsStatus Make(RoundAuctionStatusTypeEnum type, Auction auction, RoundAuction newRound = null);

    }
}

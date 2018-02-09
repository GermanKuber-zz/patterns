namespace ConsoleApp3
{
    public interface IAuctionStatusFactory
    {
        StatusAuction Make(AuctionStatusTypeEnum type, Auction auction);

    }
}

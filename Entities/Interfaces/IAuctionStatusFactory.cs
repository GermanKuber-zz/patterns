namespace ConsoleApp3
{
    public interface IAuctionStatusFactory
    {
        StatusAuction<Auction> Make(AuctionStatusTypeEnum type, Auction auction);

    }
}

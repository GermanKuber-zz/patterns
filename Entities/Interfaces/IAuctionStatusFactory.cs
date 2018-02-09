namespace Entities.Interfaces
{
    public interface IAuctionStatusFactory
    {
        StatusAuction<Auction> Make(AuctionStatusTypeEnum type, Auction auction);

    }
}

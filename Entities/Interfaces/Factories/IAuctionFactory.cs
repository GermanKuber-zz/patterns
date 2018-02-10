namespace Entities.Interfaces
{
    public interface IAuctionFactory
    {
        Auction Make(AuctionTypeEnum type);
    }
}

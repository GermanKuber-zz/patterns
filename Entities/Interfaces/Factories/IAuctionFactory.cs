namespace Entities.Interfaces
{
    public interface IAuctionFactory
    {
        AuctionBase<Auction> Make(AuctionTypeEnum type);
    }
}

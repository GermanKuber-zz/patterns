namespace Entities.Interfaces
{
    public abstract class AuctionDecorator<TParameters> : Decorator<Auction, TParameters>, IAuctionDecorator<TParameters> where TParameters : IParameters {

    }
}

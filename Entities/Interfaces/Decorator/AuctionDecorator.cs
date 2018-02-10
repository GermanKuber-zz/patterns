namespace Entities.Interfaces
{
    public abstract class AuctionDecorator<TParameters> : Decorator<Auction, TParameters>, IAuctionDecorator<TParameters> where TParameters : IParameters {

    }

    public interface IAuctionDecorator<TParameters>: IDecorator<Auction, TParameters> , IStrategy<Auction, TParameters> , IUpdateStrategy<Auction, TParameters> where TParameters : IParameters
    {
    }
}

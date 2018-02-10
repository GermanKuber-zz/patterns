namespace Entities.Interfaces
{
    public interface IAuctionDecorator<TParameters> : IDecorator<Auction, TParameters> , IStrategy<Auction, TParameters> , IUpdateStrategy<Auction, TParameters> where TParameters : IParameters
    {
    }
}

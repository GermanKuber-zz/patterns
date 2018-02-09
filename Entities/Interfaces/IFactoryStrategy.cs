namespace Entities.Interfaces
{
    public interface IFactoryUpdateStrategy<TUpdating>
    {
        IUpdateStrategy<TUpdating, TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters;
    }
    public interface IAuctionFactoryStrategy : IFactoryUpdateStrategy<Auction>
    {

    }
    public interface IRoundAuctionFactoryStrategy : IFactoryUpdateStrategy<RoundAuction>
    {

    }
}

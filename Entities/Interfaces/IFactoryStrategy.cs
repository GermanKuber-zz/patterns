namespace ConsoleApp3
{
    public interface IFactoryUpdateStrategy<TUpdating>
    {
        IUpdateStrategy<TUpdating, TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters;
    }
    public interface IAuctionFactoryStrategy : IFactoryUpdateStrategy<Auction>
    {

    }
}

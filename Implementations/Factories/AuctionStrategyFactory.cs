namespace ConsoleApp3
{
    public class AuctionStrategyFactory : IAuctionFactoryStrategy
    {
        public IUpdateStrategy<Auction,  TParam> Make<TParam>(StrategyTypeEnum type) where TParam : IParameters
        {
            switch (type)
            {
                case StrategyTypeEnum.UpdateProvider:
                    return (IUpdateStrategy<Auction, TParam>)new UpdateProvidersStrategy();
                case StrategyTypeEnum.CreateBuyer:
                    break;
                default:
                    break;
            }
            return (IUpdateStrategy<Auction, TParam>)new UpdateProvidersStrategy();
        }
    }
}

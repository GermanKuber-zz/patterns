using Entities;
using Entities.Interfaces;
using Implementations.Factories;
using Implementations.Strategies.Update.Auction;

namespace Implementations.Tests
{
    
    public class AuctionStrategyTestsBase<TParameter> {
        protected IUpdateStrategy<Auction, TParameter> Sut;
        protected IAuctionStrategyFactory AuctionStrategyFactory { get;  }
        protected IAuctionFactory AuctionFactory { get; }
        protected Auction Auction { get; set; }
        
        public AuctionStrategyTestsBase()
        {
            AuctionStrategyFactory = new AuctionStrategyFactory();
             AuctionFactory = new AuctionFactory();
            Auction = AuctionFactory.Make(AuctionTypeEnum.Complete);

        }
    }
}

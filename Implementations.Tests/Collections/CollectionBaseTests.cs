using Entities.Interfaces;
using Implementations.Factories;

namespace Implementations.Tests
{
    public class CollectionBaseTests
    {
        protected IAuctionStatusFactory _auctionStatusFactory;
        protected IRoundAuctionStatusFactory _roundAuctionStatusFactory;
        protected IAuctionStrategyFactory _auctionStrategyFactory;
        public CollectionBaseTests()
        {
            _auctionStatusFactory = new AuctionStatusFactory();
            _roundAuctionStatusFactory = new RoundAuctionStatusFactory();
            _auctionStrategyFactory = new AuctionStrategyFactory();
        }
    }
}

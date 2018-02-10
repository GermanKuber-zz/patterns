using Entities;
using Entities.Interfaces;

namespace Implementations.Factories
{
    public class AuctionFactory : IAuctionFactory
    {
        public AuctionBase<Auction> Make(AuctionTypeEnum type)
        {
            var auctionStatusFactory = new AuctionStatusFactory();
            var roundAuctionStatusFactory = new RoundAuctionStatusFactory();
            var auction = new Auction(auctionStatusFactory, roundAuctionStatusFactory, AuctionStatusTypeEnum.New);
            return auction;
        }
    }
}

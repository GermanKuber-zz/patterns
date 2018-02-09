using Entities;
using Entities.Interfaces;
using Implementations.StatusAuction;

namespace Implementations.Factories
{
    public class AuctionStatusFactory : IAuctionStatusFactory
    {


        public StatusAuction<Auction> Make(AuctionStatusTypeEnum type, Auction auction)
        {
            switch (type)
            {
                case AuctionStatusTypeEnum.New:
                    return new StatusAuctionNew(auction);
                case AuctionStatusTypeEnum.Draft:
                    return new StatusAuctionDraft(auction);
                case AuctionStatusTypeEnum.Close:
                    return new StatusAuctionClose(auction);
            }
            return new StatusAuctionNew(auction);
        }

    }


    public class AuctionFactory : IAuctionFactory
    {
        public AuctionBase<Auction> Make(AuctionTypeEnum type)
        {
            var auctionStatusFactory = new AuctionStatusFactory();
            var roundAuctionStatusFactory = new RoundAuctionStatusFactory();
            var auction = new Auction(auctionStatusFactory, roundAuctionStatusFactory);
            return auction;
        }
    }
}

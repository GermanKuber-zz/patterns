namespace ConsoleApp3
{
    public class AuctionStatusFactory : IAuctionStatusFactory
    {


        public StatusAuction Make(AuctionStatusTypeEnum type, Auction auction)
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
}

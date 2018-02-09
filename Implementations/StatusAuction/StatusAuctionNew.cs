using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionNew : StatusAuction
    {
        public StatusAuctionNew(AuctionBase auction) : base(auction)
        {
        }

        public override StatusAuction Close()
        {
            return new StatusAuctionClose(Auction);
        }

        public override StatusAuction UpdateProviders(List<Provider> providers)
        {
            return this;
        }
    }
}

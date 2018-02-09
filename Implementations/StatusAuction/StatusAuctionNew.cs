using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionNew : StatusAuction<Auction>
    {
        public StatusAuctionNew(AuctionBase<Auction> auction) : base(auction)
        {
        }

        public override StatusAuction<Auction> Close()
        {
            return new StatusAuctionClose(Auction);
        }

        public override StatusAuction<Auction> UpdateProviders(List<Provider> providers)
        {
            return this;
        }
    }
}

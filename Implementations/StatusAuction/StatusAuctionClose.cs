using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionClose : StatusAuction<Auction>
    {
        public StatusAuctionClose(AuctionBase<Auction> auction) : base(auction)
        {
        }

        public override StatusAuction<Auction> Close()
        {
            return this;
        }

        public override StatusAuction<Auction> UpdateProviders(List<Provider> providers)
        {
            return this;
        }
    }
}

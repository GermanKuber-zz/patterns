using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionClose : StatusAuction
    {
        public StatusAuctionClose(AuctionBase auction) : base(auction)
        {
        }

        public override StatusAuction Close()
        {
            return this;
        }

        public override StatusAuction UpdateProviders(List<Provider> providers)
        {
            return this;
        }
    }
}

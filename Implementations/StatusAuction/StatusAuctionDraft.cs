using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionDraft : StatusAuction
    {
        public StatusAuctionDraft(AuctionBase auction) : base(auction)
        {
        }

        public override StatusAuction Close()
        {
            if (Auction.Providers.Count <= 0)
                return this;
            else
                return new StatusAuctionClose(Auction);

        }

        public override StatusAuction UpdateProviders(List<Provider> providers)
        {
            if (providers.Count == 2)
                Auction.Providers = providers;

            return new StatusAuctionDraft(Auction);
        }
    }
}

using System.Collections.Generic;

namespace ConsoleApp3
{
    public class StatusAuctionDraft : StatusAuction<Auction>
    {
        public StatusAuctionDraft(AuctionBase<Auction> auction) : base(auction)
        {
        }

        public override StatusAuction<Auction> Close()
        {
            if (Auction.Providers.Count <= 0)
                return this;
            else
                return new StatusAuctionClose(Auction);

        }

        public override StatusAuction<Auction> UpdateProviders(List<Provider> providers)
        {
            if (providers.Count == 2)
                Auction.Providers = providers;

            return new StatusAuctionNew(Auction);
        }
    }
}

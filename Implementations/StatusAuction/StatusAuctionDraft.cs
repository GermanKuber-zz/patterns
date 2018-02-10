using System.Collections.Generic;
using Entities;
using Entities.Interfaces.Collections;

namespace Implementations.StatusAuction
{
    public class StatusAuctionDraft : StatusAuction<Auction>
    {
        public override AuctionStatusEnum Status => AuctionStatusEnum.Draft;

        public StatusAuctionDraft(AuctionBase<Auction> auction) : base(auction)
        {
        }

        public override StatusAuction<Auction> Close()
        {
            if (Auction.Providers.Get().Count <= 0)
                return this;
            else
                return new StatusAuctionClose(Auction);

        }

        public override StatusAuction<Auction> UpdateProviders(IProviders providers)
        {
            if (providers.Get().Count == 2)
                Auction.Providers = providers;

            return new StatusAuctionNew(Auction);
        }
    }
}

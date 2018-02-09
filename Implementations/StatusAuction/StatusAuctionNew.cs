using System.Collections.Generic;
using Entities;

namespace Implementations.StatusAuction
{
    public class StatusAuctionNew : StatusAuction<Auction>
    {
        public override AuctionStatusEnum Status => AuctionStatusEnum.New;

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

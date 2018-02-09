using System.Collections.Generic;
using Entities;

namespace Implementations.StatusAuction
{
    public class StatusAuctionClose : StatusAuction<Auction>
    {
        public override AuctionStatusEnum Status => AuctionStatusEnum.Cancel;

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

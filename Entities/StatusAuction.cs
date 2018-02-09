using System.Collections.Generic;

namespace ConsoleApp3
{
    public abstract class StatusAuction {
        protected AuctionBase Auction { get; }

        public StatusAuction(AuctionBase auction)
        {
            Auction = auction;
        }

        public abstract StatusAuction UpdateProviders(List<Provider> providers);
        public abstract StatusAuction Close();

    }
}

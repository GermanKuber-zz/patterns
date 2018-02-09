using System.Collections.Generic;

namespace ConsoleApp3
{
    public abstract class StatusAuction<TAuction> {
        protected AuctionBase<TAuction> Auction { get; }

        public StatusAuction(AuctionBase<TAuction> auction)
        {
            Auction = auction;
        }

        public abstract StatusAuction<TAuction> UpdateProviders(List<Provider> providers);
        public abstract StatusAuction<TAuction> Close();

    }
}

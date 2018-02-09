using System.Collections.Generic;

namespace Entities
{
    public abstract class StatusAuction<TAuction> {
        protected AuctionBase<TAuction> Auction { get; }

        public StatusAuction(AuctionBase<TAuction> auction)
        {
            Auction = auction;
        }

        public abstract AuctionStatusEnum Status { get;  }

        public abstract StatusAuction<TAuction> UpdateProviders(List<Provider> providers);
        public abstract StatusAuction<TAuction> Close();

    }

    public enum AuctionStatusEnum
    {
        Draft,
        New,
        Open,
        Cancel,
        Empty,
        Close
    }
}

using Entities.Interfaces.Collections;
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

        public abstract StatusAuction<TAuction> UpdateProviders(IProviders providers);
        public abstract StatusAuction<TAuction> Close();

    }
}

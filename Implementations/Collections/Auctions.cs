using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Interfaces.Collections;

namespace Implementations.Collections
{
    public class Auctions : IAuctions
    {
        private readonly IEnumerable<Auction> _auctions;

        public Auctions(IEnumerable<Auction> auctions)
        {
            _auctions = auctions;
        }

        public IAuctions ReadyToOpen() => new Auctions(_auctions.Where(x => x.Status.Status == AuctionStatusEnum.New
                                                                            &&
                                                                            x.OpeningDate < DateTime.Now));

        public IAuctions WithOutProviders() => new Auctions(_auctions.Where(x => x.Providers == null
                                                                                 ||
                                                                                 x.Providers.Get().Count == 0));
        public IEnumerable<Auction> Get() => _auctions;

    }
}
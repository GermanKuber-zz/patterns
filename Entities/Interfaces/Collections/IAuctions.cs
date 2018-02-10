using System.Collections.Generic;

namespace Entities.Interfaces.Collections
{
    public interface IAuctions
    {
        IAuctions ReadyToOpen();
        IAuctions WithOutProviders();
        IEnumerable<Auction> Get();
    }
}
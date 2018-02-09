using System.Collections.Generic;

namespace ConsoleApp3
{
    public abstract class AuctionBase {
        public string Title { get; set; }
        public List<Provider> Providers { get; set; }
        public StatusAuction Status { get; set; }
    }
}

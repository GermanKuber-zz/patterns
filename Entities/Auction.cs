using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class Auction : AuctionBase<Auction>, IStatus<StatusAuction<Auction>>, IEnableToUpdate<Auction>, IEnableToAdd<Auction>
    {
        public RoundAuctionsStatus RoundAuctionsStatus {  get;   set; }
     

        public Auction(IAuctionStatusFactory auctionStatusFactory,
            IRoundAuctionStatusFactory roundAuctionStatusFactory)
        {
            Status = auctionStatusFactory.Make(AuctionStatusTypeEnum.New, this);
            RoundAuctionsStatus = roundAuctionStatusFactory.Make(RoundAuctionStatusTypeEnum.HasNotRound, this);
        }



        public void Add<TParameters>(IAddStrategy<Auction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Add<TParameters>(this, updateStrategy, parameters);
        }

        public void Update<TParameters>(IUpdateStrategy<Auction, TParameters> updateStrategy, TParameters parameters) where TParameters : IParameters
        {
            base.Update<TParameters>(this, updateStrategy, parameters);
        }
    }
}
